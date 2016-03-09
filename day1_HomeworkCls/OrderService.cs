using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1_HomeworkCls
{
    public class OrderService
    {
        public List<OrderModel> GetOrderList()
        {
            List<OrderModel> lsOrderModel = new List<OrderModel>();

            return lsOrderModel;
        }
    }

    public class OrderPageService
    {
        private List<OrderModel> lsOrderModel = new List<OrderModel>();

        public OrderPageService(List<OrderModel> lsOrderModel)
        {
            this.lsOrderModel = lsOrderModel;
        }

        public IEnumerable<int> GetPageSum(string propertyName, int pageNum)
        {
            List<int> lsReoup = new List<int>();
            int page = 0;

            while (lsOrderModel.Count > page * pageNum)
            {
                int sum = 0;
                sum = lsOrderModel.Select(m => (int)m.GetType().GetProperty(propertyName).GetValue(m, null))
                                  .Skip(page*pageNum)
                                  .Take(pageNum).Sum();
                page++;
                lsReoup.Add(sum);
            }

            

            return lsReoup;
        }
    }

}
