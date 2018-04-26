using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntroSortLib;

namespace UnitTestOfIntroSort
{
    [TestClass]
    public class UTofArrayC
    {
        [TestMethod]
        public void BinSort_01()
        {
            ArrayC ac = new ArrayC(0);
            ac.BinarySorting();
            Assert.AreEqual(0, ac.ArrayM.Length);
        }
        [TestMethod]
        public void BinSort_02()
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

        [TestMethod]
        public void PyrSort_01()
        {
            ArrayC ac = new ArrayC(10);
            ac.ArrayM.mass = new int[] { 5, 4, 6, 3, 7, 2, 8, 1, 9, 0 };
            int[] expRes = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ac.PyramidalSorting();
            for (int i = 0; i < ac.ArrayM.mass.Length; i++)
            {
                Assert.AreEqual(expRes[i], ac.ArrayM.mass[i]);
            }
        }

        [TestMethod]
        public void PyrSort_02()
        {
            ArrayC ac = new ArrayC(0);
            ac.PyramidalSorting();
            Assert.AreEqual(0, ac.ArrayM.Length);
        }

        [TestMethod]
        public void IntroSort_01()
        {
            ArrayC ac = new ArrayC(10);
            ac.ArrayM.mass = new int[] { 5, 4, 6, 3, 7, 2, 8, 1, 9, 0 };
            int[] expRes = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ac.IntroSorting();
            for (int i = 0; i < ac.ArrayM.mass.Length; i++)
            {
                Assert.AreEqual(expRes[i], ac.ArrayM.mass[i]);
            }
        }

        [TestMethod]
        public void IntroSort_02()
        {
            ArrayC ac = new ArrayC(0);
            ac.IntroSorting();
            Assert.AreEqual(0, ac.ArrayM.Length);
        }
    }
}
