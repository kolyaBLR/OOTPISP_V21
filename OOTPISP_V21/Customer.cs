using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPISP_V21
{
    class Customer
    {
        public bool first;
        public Customer next;

        public int id { get; }
        public String fullName { get; set; }
        public String phone { get; set; }
        public double accountStatus { get; set; }

        public Customer(int id, String fullName, String phone, bool first = false)
        {
            this.id = id;
            this.fullName = fullName;
            this.phone = phone;
            this.first = first;
            accountStatus = 0;
        }

        public Customer Clone()
        {
            return new Customer(id, fullName, phone);
        }
    }
}
