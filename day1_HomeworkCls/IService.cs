using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1_HomeworkCls
{
    public interface IService<T>
    {
        List<T> GetOrderList();
    }
}
