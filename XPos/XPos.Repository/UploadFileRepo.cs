using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPos.DataModel;

namespace XPos.Repository
{
    public class UploadFileRepo
    {
        public static List<FileCollection> All()
        {
            List<FileCollection> result = new List<FileCollection>();
            using (var db = new XPosContext())
            {
                result = db.FileCollections
                    .ToList();
            }
            return result;
        }

        public static Pagination Paging(int page, int perPage)
        {
            //page: request halaman ke berapa
            //perPage: brp row/data per halaman

            Pagination result = new Pagination();
            using (var db = new XPosContext())
            {
                int rowCnt = db.FileCollections.Count();
                int pageCnt = rowCnt / perPage;
                if ((rowCnt / perPage) % perPage != 0)
                {
                    pageCnt++;
                }

                List<FileCollection> list = db.FileCollections
                    .OrderByDescending(o => o.CreateDate)
                    .Skip((page - 1) * perPage)
                    .Take(perPage)
                    .ToList();

                result.ListOf = list;
                result.Pages = pageCnt;
            }
            return result;
        }

        public static ResponseResult Update(FileCollection entity)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new XPosContext())
                {
                    if (entity.Id == 0)
                    {
                        entity.CreateBy = "Dimas";
                        entity.CreateDate = DateTime.Now;

                        db.FileCollections.Add(entity);
                        db.SaveChanges();

                        result.Entity = entity;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
