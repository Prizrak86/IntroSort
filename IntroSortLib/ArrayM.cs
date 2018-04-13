using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSortLib
{
    public class ArrayM
    {
        public int[] mass;
        public int this[int ind]
        {
            get { return mass[ind]; }
            set { mass[ind] = value; }
        }
        public int Length { get { return mass.Length; } }
    }
}
