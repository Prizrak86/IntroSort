using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSortLib
{
    public class ArrayC : ArrayI
    {
        public ArrayM ArrayM { get; set; }
        public ArrayC(int size)
        {
            ArrayM array = new ArrayM();
            array.mass = new int[size];
            Random rns = new Random();
            for (int i = 0; i < size; i++)
                array[i] = rns.Next(100);
            this.ArrayM = array;
        }


        public void BinarySorting()
        {
            BinarySorting(0, ArrayM.mass.Length - 1);
        }

        public void BinarySorting(int left, int right)
        {
            int size = right - left + 1;
            int[] leftArray = new int[size];
            int[] centerArray = new int[size];
            int[] rightArray = new int[size];
            int referencePoint = left;
            int iLeft = 0, iCenter = 0, iRight = 0;
            for (int i = left; i <= right; i++)
                if (ArrayM[i] < ArrayM[referencePoint]) leftArray[iLeft++] = ArrayM[i];
                else if (ArrayM[i] > ArrayM[referencePoint]) rightArray[iRight++] = ArrayM[i];
                else centerArray[iCenter++] = ArrayM[i];
            Array.Copy(leftArray, 0, ArrayM.mass, left, iLeft);
            Array.Copy(centerArray, 0, ArrayM.mass, left + iLeft, iCenter);
            Array.Copy(rightArray, 0, ArrayM.mass, left + iLeft + iCenter, iRight);
            if (iLeft > 1) BinarySorting(left, left + right - 1);
            if (iRight > 1) BinarySorting(right - iRight + 1, right);
        }

        public void PyramidalSorting()
        {
            throw new NotImplementedException();
        }

        public void IntroSorting()
        {
            throw new NotImplementedException();
        }
    }
}
