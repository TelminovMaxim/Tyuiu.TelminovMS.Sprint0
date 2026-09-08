using Tyuiu.TelminovMS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.TelminovMS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Максим";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Максим", res);
        }
    }
}
