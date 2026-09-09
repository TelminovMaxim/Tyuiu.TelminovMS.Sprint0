using Tyuiu.TelminovMS.Sprint0.Task6.V0.Lib;

namespace Tyuiu.TelminovMS.Sprint0.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var number = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(number);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void CheckSubstractionArrayValid()
        {
            var number = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstracyionArray(number);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]
        public void CheckMultiplicationArrayValid()
        {
            var number = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(number);
            Assert.AreEqual(120, res);
        }
    }
}
