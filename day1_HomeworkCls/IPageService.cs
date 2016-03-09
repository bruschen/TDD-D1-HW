using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1_HomeworkCls
{
    public interface IPageService
    {
        IEnumerable<int> GetPageSum(string propertyName, int pageNum);
    }
}
