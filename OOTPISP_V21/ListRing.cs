using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPISP_V21
{
    class ListRing : AbstractList
    {
        private Customer first;
        private int count = 0;

        public override void Add(String fullName, String phone)
        {
            Customer newCustomer = new Customer(count++, fullName, phone);
            if (customer == null)
            {
                //если список пустой то просто создали новый элемент
                //так же пометили что он первый, и зациклили его
                customer = newCustomer;
                customer.next = customer;
                customer.first = true;
                //сохраняем первый элемент что бы была метка начала поиск
                first = customer;
            }
            else
            {
                //если список не пустой то вставляем новый объект между текущим и следующим
                newCustomer.next = customer.next;
                customer.next = newCustomer;
            }
        }

        public override Customer Search(String fullName, String phone)
        {
            //переходим в начало списка
            customer = first;
            //проходим по всему списку
            do
            {
                //ищем совпадения
                if (customer.fullName == fullName && customer.phone == phone)
                {
                    //возвращаем клона, что бы не получили наши ссылки на другие объекты
                    return customer.Clone();
                }
                //переходим к следующему элементу
                customer = customer.next;
            }
            while (!customer.first);
            //если ничего не нашли то null
            return null;
        }

        public override void Update(Customer newCustomer)
        {
            customer = first;
            do
            {
                if (customer.id == newCustomer.id)
                {
                    customer.phone = newCustomer.phone;
                    customer.fullName = newCustomer.fullName;
                }
                customer = customer.next;
            }
            while (!customer.first);
        }

        public void Print()
        {
            customer = first;
            Console.WriteLine("Список всех абонентов:");
            if (customer == null)
            {
                Console.WriteLine("Список пуст.");
                return;
            }
            do
            {
                Console.WriteLine("телефон: {0} ФИО: {1}", customer.phone.toString(), customer.fullName.toString());
                customer = customer.next;
            }
            while (!customer.first);
        }
    }
}
