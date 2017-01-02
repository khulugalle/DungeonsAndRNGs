using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndRngs.Common.Utility
{
    /// <summary>
    /// Utility class for dealing with numbers
    /// </summary>
    public static class NumberUtil
    {
        #region Double Extensions

        public static double RoundToNearest(this double number, double precision)
        {
            return Math.Round(number / precision) * precision;
        }

        public static double RoundToCeiling(this double number, double precision)
        {
            return Math.Ceiling(number / precision) * precision;
        } 

        #endregion
    }
}
