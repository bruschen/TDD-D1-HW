using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day1_HomeworkCls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpectedObjects;

namespace day1_HomeworkCls.Tests
{
    [TestClass()]
    public class PageSumHelperTests
    {
        private List<OrderModel> GetOrders()
        {
            return new List<OrderModel>(){
                new OrderModel{ ID=1, Cost=1, Revenue=11, SellPrice=21},
                new OrderModel{ ID=2, Cost=2, Revenue=12, SellPrice=22},
                new OrderModel{ ID=3, Cost=3, Revenue=13, SellPrice=23},
                new OrderModel{ ID=4, Cost=4, Revenue=14, SellPrice=24},
                new OrderModel{ ID=5, Cost=5, Revenue=15, SellPrice=25},
                new OrderModel{ ID=6, Cost=6, Revenue=16, SellPrice=26},
                new OrderModel{ ID=7, Cost=7, Revenue=17, SellPrice=27},
                new OrderModel{ ID=8, Cost=8, Revenue=18, SellPrice=28},
                new OrderModel{ ID=9, Cost=9, Revenue=19, SellPrice=29},
                new OrderModel{ ID=10, Cost=10, Revenue=20, SellPrice=30},
                new OrderModel{ ID=11, Cost=11, Revenue=21, SellPrice=31}
            };
        }

        [TestMethod()]
        public void PageSumHelper_訂單_屬性_Cost_分頁_3()
        {
            //Arrange
            var target = new PageSumHelper<OrderModel>(GetOrders()) { };
            string propertyName = "Cost";
            int pageNum = 3;

            var expected = new List<int>() { 6, 15, 24, 21 };

            //Act
            var actual = target.GetPageSum(propertyName, pageNum);

            //Assert
            expected.ToExpectedObject().ShouldEqual(actual);

        }
    }
}
