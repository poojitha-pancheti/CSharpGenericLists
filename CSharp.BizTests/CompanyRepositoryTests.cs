using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Biz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp.Biz.Tests
{
    [TestClass()]
    public class CompanyRepositoryTests
    {
        
        
        [TestMethod()]
        public void RetrieveTest()
        {
            var repository = new CompanyRepository();

            var expected = new List<Company>();
            expected.Add(new Company()
            { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
            expected.Add(new Company()
            { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });

            var actual = repository.Retrieve();

            CollectionAssert.AreEqual(expected, actual);

        }
    }
}


