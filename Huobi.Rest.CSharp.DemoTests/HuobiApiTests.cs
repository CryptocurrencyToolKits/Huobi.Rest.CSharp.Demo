using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Huobi.Rest.CSharp.Demo.Tests
{
    [TestClass()]
    public class HuobiApiTests
    {
        HuobiApi api = new HuobiApi("ed80fc08-ae45ccce-b538d02a-3d8d2", "01dc4111-73ea09ec-9ee9a534-9e412");
        [TestMethod()]
        public void GetAllAccountTest()
        {
            var result = api.GetAllAccount();
            Assert.IsNull(result);
        }
    }
}