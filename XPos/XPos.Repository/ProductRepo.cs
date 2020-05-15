using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPos.DataModel;

namespace XPos.Repository
{
    public class ProductRepo
    {
        //List
        public static List<Product> All()
        {
            List<Product> result = new List<Product>();
            using (var db = new XPosContext())
            {
                result = db.Products
                    .Include("Variant")
                    .ToList();
            }
            return result;
        }

        //List by Variant
        public static List<Product> ByVariant(long varId)
        {
            // varId => Variant Id
            List<Product> result = new List<Product>();
            using (var db = new XPosContext())
            {
                result = db.Products
                    .Where(o => o.VariantId == varId)
                    .ToList();
            }
            return result;
        }
        public static List<Product> BySearch(string search)
        {
            List<Product> result = new List<Product>();
            using (var db = new XPosContext())
            {
                result = db.Products
                    .Where(p => p.Active == true &&
                    (p.Initial.Contains(search) || p.Name.Contains(search) || p.Description.Contains(search)))
                    .Take(10)
                    .ToList();
            }
            return result;
        }


        //Create
        public static ResponseResult Update(Product entity)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new XPosContext())
                {
                    if (entity.Id == 0)
                    {
                        // Create
                        entity.Variant = null;
                        entity.CreateBy = "Dimas";
                        entity.CreateDate = DateTime.Now;
                        db.Products.Add(entity);
                        db.SaveChanges();
                        result.Message = "Created";
                        result.Entity = entity;
                    }
                    else
                    {
                        //Edit
                        Product product = db.Products
                            .Where(o => o.Id == entity.Id)
                            .FirstOrDefault();
                        if (product == null)
                        {
                            result.Success = false;
                        }
                        else
                        {
                            product.VariantId = entity.VariantId;

                            product.Initial = entity.Initial;
                            product.Name = entity.Name;
                            product.Description = entity.Description;
                            product.Price = entity.Price;
                            product.Stock = entity.Stock;
                            product.Active = entity.Active;
                            product.ModifyBy = "Dimas";
                            product.ModifyDate = DateTime.Now;
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
        public static Product ById(long id)
        {
            Product result = new Product();
            using (var db = new XPosContext())
            {
                result = db.Products
                    .Include("Variant")
                    .Where(o => o.Id == id)
                    .FirstOrDefault();
            }
            return result;
        }

    }
}
