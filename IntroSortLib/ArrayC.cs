﻿using System;

namespace IntroSortLib
{
    public class ArrayC : ArrayI
    {
        /// <summary>
        /// Массив с данными
        /// </summary>
        public ArrayM ArrayM { get; set; }
        /// <summary>
        /// Конструктор создающий и заполняющий массив
        /// </summary>
        /// <param name="size">Размер массива</param>
        public ArrayC(int size)
        {
            ArrayM array = new ArrayM();
            array.mass = new int[size];
            Random rns = new Random();
            for (int i = 0; i < size; i++)
                array[i] = rns.Next(100);
            array.ln = Math.Log(size) * 2;
            this.ArrayM = array;
            ArrayM.History HistoryI = new ArrayM.History();
            HistoryI.array = (int[])ArrayM.mass.Clone();
            HistoryI.commet = "Создано множество";
            ArrayM.history.Add(HistoryI);
        }

        /// <summary>
        /// Сортирует используя бинарную сортировку
        /// </summary>
        public void BinarySorting()
        {
            BinarySorting(0, ArrayM.mass.Length - 1);
        }
        /// <summary>
        /// Рекурсивный вызов бинарной сортировки
        /// </summary>
        /// <param name="left">левая граница сортируемого диапазона</param>
        /// <param name="right">правая граница сортируемого диапазона</param>
        /// <param name="introSort">Если истина то применяет алгоритм "Интроспективная сортировка",
        /// иначе (по умолчанию) применяет алгоритм бинарной сортировки</param>
        private void BinarySorting(int left, int right, bool introSort = false)
        {
            ///вычисляем размер сортируемого диапазона
            int size = right - left + 1;
            if (introSort && size <= ArrayM.ln)
            {
                PyramidalSorting(left, right);
                return;
            }

            int[] leftArray = new int[size];
            int[] centerArray = new int[size];
            int[] rightArray = new int[size];
            ///индексы к массивам выше, хронящие индекс куда следует записывать
            int iLeft = 0, iCenter = 0, iRight = 0;
            ///опорная точка
            int referencePoint = left;
            #region распределяем значения из исходного массива по трем подмассивам относительно опорной точки
            for (int i = left; i <= right; i++)
                if (ArrayM[i] < ArrayM[referencePoint]) leftArray[iLeft++] = ArrayM[i];
                else if (ArrayM[i] > ArrayM[referencePoint]) rightArray[iRight++] = ArrayM[i];
                else centerArray[iCenter++] = ArrayM[i];
            ///копирование в исходный массив
            Array.Copy(leftArray, 0, ArrayM.mass, left, iLeft);
            Array.Copy(centerArray, 0, ArrayM.mass, left + iLeft, iCenter);
            Array.Copy(rightArray, 0, ArrayM.mass, left + iLeft + iCenter, iRight);

            #endregion
            ///рекурсивные вызовы для сортирвоки левого и правого диапазонов значений
            if (iLeft > 1) BinarySorting(left, left + iLeft, introSort);
            if (iRight > 1) BinarySorting(right - iRight + 1, right, introSort);
            ArrayM.History HistoryI = new ArrayM.History();
            HistoryI.array = (int[])ArrayM.mass.Clone();
            HistoryI.commet = "Итерация бинарной сортировки";
            ArrayM.history.Add(HistoryI);
        }
        /// <summary>
        /// Пирамидальная сортировка
        /// </summary>
        public void PyramidalSorting()
        {
            PyramidalSorting(0, ArrayM.Length - 1);
        }
        /// <summary>
        /// пирамидальная сортировка указанного диапазона
        /// </summary>
        /// <param name="left">левая граница сортируемого диапазона</param>
        /// <param name="right">правая граница сортируемого диапазона</param>
        private void PyramidalSorting(int left, int right)
        {
            ///вычисляем размер сортируемого диапазона
            int len = right - left + 1;
            #region построение опорной пирамиды
            ///проход по элементам пирамиды начиная от правого края первой половины 
            ///заканчивая левым краем первой половины
            for (int i = len / 2 - 1; i >= 0; --i)
            {
                int prev_i = i;
                i = add2pyramid(left, i, len);
                if (prev_i != i) ++i;
            }
            #endregion
            ArrayM.History HistoryI = new ArrayM.History();
            HistoryI.array = (int[])ArrayM.mass.Clone();
            HistoryI.commet = "Построена опорная пирамида";
            ArrayM.history.Add(HistoryI);
            #region сортировка
            int buf;
            ///перебор неотсортированного диапазона
            ///к - указывает на правую границу этого неотсортированного диапазона.
            for (int k = len - 1; k > 0; --k)
            {
                buf = ArrayM[left];
                ArrayM[left] = ArrayM[left + k];
                ArrayM[left + k] = buf;
                ///индекс сортируемой вершины и индекс на предыдущей итерации,
                ///что бы знать изменилось ли i после выполднение замены значений в пирамиде
                int i = 0, prev_i = -1;
                while (i != prev_i)
                {
                    prev_i = i;
                    i = add2pyramid(left, i, k);
                }
            }
            #endregion
        }
        /// <summary>
        /// Меняет местами дочерние вершины указанной вершиной на максимальную по значению вершину
        /// </summary>
        /// <param name="left">левая граница сортируемого диапазона и она же является первым элементом пирамиды</param>
        /// <param name="i">сортируемая вершина</param>
        /// <param name="size">количество элементов в прирамиде</param>
        /// <returns>возвращается i, если оно отлично от входного параметра, то необходимо продолжить цепочку сортировок</returns>
        int add2pyramid(int left, int i, int size)
        {

            int imax;
            int buf;
            ///если сортируенмая вершина имеет два дочерних элемента
            if ((2 * i + 2) < size)
            {
                ///если левый дочерний элемент меньше правого дочернего элемента
                if (ArrayM[2 * i + 1 + left] < ArrayM[2 * i + 2 + left])
                    ///записать индекс правого дочернего элемента, максимальный по значению
                    imax = 2 * i + 2;
                else
                    ///записать индекс левого дочернего элемента, максимальный по значению
                    imax = 2 * i + 1;
            }
            ///иначе у сортируемой вершины один дочерний элемент
            else
                ///записать индекс левого дочернего элемента
                imax = 2 * i + 1;
            ///контрольная проверка правильности индекса
            ///индекс не может быть больше чем количество элементов в пирамиде
            if (imax >= size) return i;
            ///если сортируемая вершина меньше чем максимальная дочерняя вершина
            if (ArrayM[i + left] < ArrayM[imax + left])
            {
                ///меняем местами
                buf = ArrayM[i + left];
                ArrayM[i + left] = ArrayM[imax + left];
                ArrayM[imax + left] = buf;
                ArrayM.History HistoryI = new ArrayM.History();
                HistoryI.array = (int[])ArrayM.mass.Clone();
                HistoryI.commet = "Перестановка пирамидальной сортировки";
                ArrayM.history.Add(HistoryI);
                ///если дочерняя максимальная вершина лежит в первой половине пирамиды
                ///то необходимо сообщить что ее нужно дальше сортировать
                if (imax < size / 2)
                    ///передача индекса следующего сортируемого элемента
                    ///которым являетися максимальный дочерний элемент
                    i = imax;
            }
            return i;
        }

        public void IntroSorting()
        {
            BinarySorting(0, ArrayM.mass.Length - 1, true);
        }
    }
}
