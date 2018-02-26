using Huobi.Rest.CSharp.Demo;
using Huobi.Rest.CSharp.Demo.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Huobi.Rest.CSharp.Demo.Tests
{
    [TestClass()]
    public class HuobiApiTests
    {
        HuobiApi api = new HuobiApi("", "");
        [TestMethod()]
        public void GetAllAccountTest()
        {
            var result = api.GetAllAccount();
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void OrderPlaceTest()
        {
            var accounts = api.GetAllAccount();
            var spotAccountId = accounts.FirstOrDefault(a => a.Type == "spot" && a.State == "working")?.Id;
            if (spotAccountId <= 0)
                throw new ArgumentException("spot account unavailable");
            OrderPlaceRequest req = new OrderPlaceRequest();
            req.account_id = spotAccountId.ToString();
            req.amount = "0.1";
            req.price = "800";
            req.source = "api";
            req.symbol = "ethusdt";
            req.type = "buy-limit";
            var result = api.OrderPlace(req);
            Assert.AreEqual(result.Status, "ok");
        }
    }
}