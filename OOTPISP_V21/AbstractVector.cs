using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPISP_V21
{
    abstract class AbstractVector
    {
        public List<int> Vector { get; set; }
        public abstract void Sort();
    }
}
