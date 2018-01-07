using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPISP_V21
{
    abstract class AbstractList
    {
        protected Customer customer;
        public abstract void Add(String fullName, String phone);
        public abstract void Update(Customer customer);
        public abstract Customer Search(String phone, String fullName);
    }
}
