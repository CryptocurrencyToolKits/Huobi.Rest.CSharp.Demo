using Microsoft.VisualStudio.TestTools.UnitTesting;

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