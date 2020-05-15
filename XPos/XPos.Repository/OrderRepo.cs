using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPos.DataModel;

namespace XPos.Repository
{
    public class OrderRepo
    {
        public static ResponseResult Insert(OrderHeader entity)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new XPosContext())
                {
                    string newRef = GetNewReference();
                    OrderHeader oh = new OrderHeader();
                    oh.Amount = entity.Amount;
                    oh.Reference = newRef;
                    oh.Active = true;

                    oh.CreateBy = "Dimas";
                    oh.CreateDate = DateTime.Now;

                    db.OrderHeaders.Add(oh);

                    foreach (var item in entity.OrderDetails)
                    {
                        OrderDetail od = new OrderDetail();
                        //OrderHeader -> Id
                        od.HeaderId = oh.Id;
                        od.ProductId = item.ProductId;
                        od.Price = item.Price;
                        od.Quantity = item.Quantity;
                        od.Active = true;

                        od.CreateBy = "Dimas";
                        od.CreateDate = DateTime.Now;

                        db.OrderDetails.Add(od);
                    }

                    db.SaveChanges();

                    entity.Reference = newRef;
                    result.Entity = entity;

                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public static string GetNewReference()
        {
            string yearMonth = DateTime.Now.ToString("yy") + DateTime.Now.Month.ToString("D2");
            string result = "SLS-" + yearMonth + "-";
            using (var db = new XPosContext())
            {
                var maxRef = db.OrderHeaders
                    .Where(o => o.Reference.Contains(result))
                    .Select(o => new { reference = o.Reference })
                    .OrderByDescending(o => o.reference)
                    .FirstOrDefault();

                if (maxRef != null)
                {
                    string[] lastRef = maxRef.reference.Split('-');
                    int newInc = int.Parse(lastRef[2]) + 1;
                    result += newInc.ToString("D4");
                }
                else
                {
                    result += "0001";
                }
            }
            return result;
        }
    }
}
