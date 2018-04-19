using System;

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
            int len = ArrayM.Length;
            //step 1: построение пирамиды
            for (int i = len / 2 - 1; i >= 0; --i)
            {
                int prev_i = i;
                i = add2pyramid(i, len);
                if (prev_i != i) ++i;
                
            }

            //step 2: сортировка
            int buf;
            for (int k = len - 1; k > 0; --k)
            {
                buf = ArrayM[0];
                ArrayM[0] = ArrayM[k];
                ArrayM[k] = buf;
                int i = 0, prev_i = -1;
                while (i != prev_i)
                {
                    prev_i = i;
                    i = add2pyramid(i, k);
                }
            }
        }
        int add2pyramid(int i, int N)
        {
            int imax;
            int buf;
            if ((2 * i + 2) < N)
            {
                if (ArrayM[2 * i + 1] < ArrayM[2 * i + 2]) imax = 2 * i + 2;
                else imax = 2 * i + 1;
            }
            else imax = 2 * i + 1;
            if (imax >= N) return i;
            if (ArrayM[i] < ArrayM[imax])
            {
                buf = ArrayM[i];
                ArrayM[i] = ArrayM[imax];
                ArrayM[imax] = buf;
                if (imax < N / 2) i = imax;
            }
            return i;
        }
        public void IntroSorting()
        {
            throw new NotImplementedException();
        }
    }
}
