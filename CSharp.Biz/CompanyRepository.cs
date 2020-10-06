using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Biz
{
    public class CompanyRepository
    {
        private List<Company> companies;
        public Company Retrieve(int vendorId)
        {

            Company vendor = new Company();


            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }
        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            T value = defaultValue;
            return value;
        }
       
        public List<Company> Retrieve()
        {
            if ( companies == null)
            {
                companies = new List<Company>();
                companies.Add(new Company() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
                companies.Add(new Company() { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });
            }
            //for (int i = 0; i < companies.Count; i++)
            //{
            //    Console.WriteLine(companies[i]);
            //}
            foreach (var company in companies)
            {
                Console.WriteLine(company);
            }
            // Console.WriteLine(vendors[1]);
            return companies;
        }
    }
}
