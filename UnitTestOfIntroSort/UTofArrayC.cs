using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntroSortLib;

namespace UnitTestOfIntroSort
{
    [TestClass]
    public class UTofArrayC
    {
        [TestMethod]
        public void Points0()
        {
            ArrayC ac = new ArrayC(0);
            int[] expRes = {};
            ac.BinarySorting();
            for (int i = 0; i < ac.ArrayM.mass.Length; i++)
            {
                Assert.AreEqual(expRes[i], ac.ArrayM.mass[i]);
            }
        }
        [TestMethod]
        public void Points_5_4_6_3_7_2_8_1_9_0()
        {
            ArrayC ac = new ArrayC(10);
            ac.ArrayM.mass = new int[]{5,4,6,3,7,2,8,1,9,0 };
            int[] expRes = {0,1,2,3,4,5,6,7,8,9 };
            ac.BinarySorting();
            for (int i = 0; i < ac.ArrayM.mass.Length; i++)
            {
                Assert.AreEqual(expRes[i], ac.ArrayM.mass[i]);
            }
        }
    }
}
