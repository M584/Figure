using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// 
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int Y { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int Z { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        double GetVolume();
    }
}
