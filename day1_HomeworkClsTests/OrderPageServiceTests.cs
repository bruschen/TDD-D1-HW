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
    public class OrderPageServiceTests
    {
        private List<OrderModel> GetOrders()
        {
            return  new List<OrderModel>(){
                new OrderModel{ ID=1, Cost=1, Revenue=11, SellPrice=21},
                new OrderModel{ ID=2, Cost=2, Revenue=12, SellPrice=22},
                new OrderModel{ ID=3, Cost=3, Revenue=13, SellPrice=23},
                new OrderModel{ ID=4, Cost=4, Revenue=14, SellPrice=24},
                new OrderModel{ ID=5, Cost=5, Revenue=15, SellPrice=25},
                new OrderModel{ ID=6, Cost=6, Revenue=16, SellPrice=26},
                new OrderModel{ ID=7, Cost=7, Revenue=17, SellPrice=27},
            };
        }


        [TestMethod()]
        public void GetPageSumTest_屬性_Cost_分頁_3()
        {
            //Arrange
            var target = new OrderPageService(GetOrders()) { };
            string propertyName = "Cost";
            int pageNum=3;

            var expected = new List<int>() { 6, 15, 7 };

            //Act

            var actual = target.GetPageSum(propertyName, pageNum);

            //Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void GetPageSumTest_屬性_Revenue_分頁_4()
        {
            //Arrange
            var target = new OrderPageService(GetOrders()) { };
            string propertyName = "Revenue";
            int pageNum = 4;

            var expected = new List<int>() { 50, 48 };

            //Act
            var actual = target.GetPageSum(propertyName, pageNum);

            //Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
