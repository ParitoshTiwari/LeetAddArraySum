using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetAddArraySum{
    [TestClass]
    public class TestHelper{
        [TestMethod]
        public void TwoSumTest(){
            int[] twoInt = {1,-1,-8,9};
            int target = 1;
            int[] result = Helper.TwoSum(twoInt,target);

            Assert.AreEqual(result[0], 2);
            Assert.AreEqual(result[1], 3);
        }
    }
}