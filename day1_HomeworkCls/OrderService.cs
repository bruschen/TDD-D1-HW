using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1_HomeworkCls
{
    public class OrderService : IService<OrderModel>
    {
        public List<OrderModel> GetOrderList()
        {
            List<OrderModel> lsOrderModel = new List<OrderModel>();

            return lsOrderModel;
        }
    }

    public class OrderPageService : IPageService
    {
        private List<OrderModel> lsOrderModel = new List<OrderModel>();

        public OrderPageService(List<OrderModel> lsOrderModel)
        {
            this.lsOrderModel = lsOrderModel;
        }

        public IEnumerable<int> GetPageSum(string propertyName, int pageNum)
        {
            PageSumHelper<OrderModel> pageSumHelper = new PageSumHelper<OrderModel>(lsOrderModel);

            return pageSumHelper.GetPageSum(propertyName, pageNum);
        }
    }

}
