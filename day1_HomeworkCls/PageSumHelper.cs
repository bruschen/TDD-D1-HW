using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1_HomeworkCls
{
    public class PageSumHelper<T>
    {
        private List<T> lsModel = new List<T>();

        public PageSumHelper(List<T> lsModel)
        {
            this.lsModel = lsModel;
        }

        public IEnumerable<int> GetPageSum(string propertyName, int pageNum)
        {
            List<int> lsReoup = new List<int>();
            int page = 0;

            while (lsModel.Count > page * pageNum)
            {
                int sum = 0;
                sum = lsModel.Select(m => (int)m.GetType().GetProperty(propertyName).GetValue(m, null))
                                  .Skip(page * pageNum)
                                  .Take(pageNum).Sum();
                page++;
                lsReoup.Add(sum);
            }

            return lsReoup;
        }
    }
}
