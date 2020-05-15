using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPos.DataModel;

namespace XPos.Repository
{
    public class VariantRepo
    {
        //List
        public static List<Variant> All()
        {
            List<Variant> result = new List<Variant>();
            using (var db = new XPosContext())
            {
                result = db.Variants
                    .Include("Category")
                    .ToList();
            }
            return result;
        }
        //List dari Category
        public static List<Variant> ByCategory(long catId)
        {
            //catId = CategoryId
            List<Variant> result = new List<Variant>();
            using (var db = new XPosContext())
            {
                result = db.Variants
                    .Where(o => o.CategoryId == (catId != 0 ? catId : o.CategoryId))
                    .ToList();
            }
            return result;
        }

        //Create
        public static ResponseResult Update(Variant entity)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new XPosContext())
                {
                    if (entity.Id == 0)
                    {
                        // Create
                        entity.CreateBy = "Dimas";
                        entity.CreateDate = DateTime.Now;
                        db.Variants.Add(entity);
                        db.SaveChanges();
                        result.Message = "Created";
                        result.Entity = entity;
                    }
                    else
                    {
                        //Edit
                        Variant variant = db.Variants
                            .Where(o => o.Id == entity.Id)
                            .FirstOrDefault();
                        if (variant == null)
                        {
                            result.Success = false;
                        }
                        else
                        {
                            variant.CategoryId = entity.CategoryId;

                            variant.Initial = entity.Initial;
                            variant.Name = entity.Name;
                            variant.Active = entity.Active;
                            variant.ModifyBy = "Dimas";
                            variant.ModifyDate = DateTime.Now;
                            db.SaveChanges();

                            result.Message = "Updated";
                            result.Entity = entity;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }
            return result;
        }
    }
}
