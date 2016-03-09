using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1_HomeworkCls
{
    public class ProductService:IService<ProductModel>
    {
        public List<ProductModel> GetOrderList()
        {
            throw new NotImplementedException();
        }
    }

    public class ProductPageService:IPageService
    {
        private List<ProductModel> lsProductModel = new List<ProductModel>();

        public ProductPageService(List<ProductModel> lsProductModel)
        {
            this.lsProductModel = lsProductModel;
        }

        public IEnumerable<int> GetPageSum(string propertyName, int pageNum)
        {
            PageSumHelper<ProductModel> pageSumHelper = new PageSumHelper<ProductModel>(lsProductModel);

            return pageSumHelper.GetPageSum(propertyName, pageNum);
        }
    }
}
