using Microsoft.VisualStudio.TestTools.UnitTesting;
using Huobi.Rest.CSharp.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huobi.Rest.CSharp.Demo.Tests
{
    [TestClass()]
    public class HuobiApiTests
    {
        HuobiApi api = new HuobiApi();
        [TestMethod()]
        public void GetAllAccountTest()
        {
            var result = api.GetAllAccount();
            Assert.IsNull(result);
        }
    }
}