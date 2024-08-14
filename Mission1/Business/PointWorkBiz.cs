using System.Collections.Generic;
using System.Linq;
using Mission1.Model;
using System;
using System.Data;
    
namespace Mission1.Business
{
    public class PointWorkBiz : IPointWorkBiz
    {
        private static PointWorkBiz pointWorkBiz;
        private static Dictionary<string, Customer> Customers { get; set; }

        private PointWorkBiz()
        {
            Customers = FileDB.LoadCustomer();

            if (Customers == null)
                Customers = new Dictionary<string, Customer>();
        }

        ~PointWorkBiz()
        {
            FileDB.SaveCustomer(Customers);
        }

        public static PointWorkBiz GetInstance()
        {
            if (pointWorkBiz == null)
                pointWorkBiz = new PointWorkBiz();

            return pointWorkBiz;
        }

        public List<Customer> GetCustomersSortedByLastVisitDate()
        {
            var customerValueList = Customers.Values.ToList();

            // Bubble Sort untuk mengurutkan berdasarkan LastVisitDate dalam urutan menurun
            for (int i = 0; i < customerValueList.Count - 1; i++)
            {
                for (int j = 0; j < customerValueList.Count - i - 1; j++)
                {
                    if (customerValueList[j].LastVisitDate < customerValueList[j + 1].LastVisitDate)
                    {
                        // Menggunakan tuple untuk menukar elemen
                        (customerValueList[j], customerValueList[j + 1]) = (customerValueList[j + 1], customerValueList[j]);
                    }
                }
            }

            return customerValueList;
        }

        public List<Customer> GetCustomersSortedByVisitCount()
        {
            var customerValueList = Customers.Values.ToList();

            // Bubble Sort untuk mengurutkan berdasarkan VisitCount dalam urutan menurun
            for (int i = 0; i < customerValueList.Count - 1; i++)
            {
                for (int j = 0; j < customerValueList.Count - i - 1; j++)
                {
                    if (customerValueList[j].VisitCount < customerValueList[j + 1].VisitCount)
                    {
                        // Menggunakan tuple untuk menukar elemen
                        (customerValueList[j], customerValueList[j + 1]) = (customerValueList[j + 1], customerValueList[j]);
                    }
                }
            }

            return customerValueList;
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer.PhoneNo, customer);
            FileDB.SaveCustomer(Customers);
        }

        public Customer GetCustomer(string phoneNo)
        {
            if (Customers.ContainsKey(phoneNo))
                return Customers[phoneNo];
            else
                return null;
        }
    }
}


