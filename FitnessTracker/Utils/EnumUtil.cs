using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Utils
{
    public static class EnumUtil
    {
        public static object[] LoadItems<T>()
        {
            var array = Enum.GetValues(typeof(T));
            object[] objArr = new object[array.Length];
            array.CopyTo(objArr, 0);

            return objArr;
        }
    }
}
