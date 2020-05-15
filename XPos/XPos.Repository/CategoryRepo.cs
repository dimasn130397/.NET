using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPos.DataModel;

namespace XPos.Repository
{
    public class CategoryRepo
    {
        //List
        public static List<Category> All()
        {
            List<Category> result = new List<Category>();
            using (var db = new XPosContext())
            {
                result = db.Categories.ToList();
            }
            return result;
        }

        //Create
        public static ResponseResult Update(Category entity)
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
                        db.Categories.Add(entity);
                        db.SaveChanges();

                        result.Message = "Created";

                    }
                    else
                    {
                        //Edit
                        Category category = db.Categories
                            .Where(o => o.Id == entity.Id)
                            .FirstOrDefault();
                        if (category == null)
                        {
                            result.Success = false;
                        }
                        else
                        {
                            category.Initial = entity.Initial;
                            category.Name = entity.Name;
                            category.Active = entity.Active;
                            category.ModifyBy = "Dimas";
                            category.ModifyDate = DateTime.Now;
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

        public static Category ById(long id)
        {
            Category result = new Category();
            try
            {
                using (var db = new XPosContext())
                {
                    result = db.Categories
                        .Where(o => o.Id == id)
                        .FirstOrDefault();
                    //if (result == null)
                    //{
                    //    result = new Category();
                    //}
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return result == null ? new Category() : result;
        }

        public static ResponseResult Delete(long id)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new XPosContext())
                {
                    Category category = db.Categories
                        .Where(o => o.Id == id)
                        .FirstOrDefault();
                    if (category != null)
                    {
                        db.Categories.Remove(category);
                        db.SaveChanges();
                    } else
                    {
                        result.Success = false;
                        result.Message = "Category not found";
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
