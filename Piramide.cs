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
    public class Piramide : IFigure
    {
        /// <summary>
        /// 
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Z { get; set; }

        public double a
        {
            get
            {
                return _a;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _a = value;
                }
            }
        }
        public double h
        {
            get
            {
                return _h;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _h = value;
                }
            }
        }
        public double H
        {
            get
            {
                return _H;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _H = value;
                }
            }
        }

        /// <summary>
        ///Расчёт объёма пирамиды
        /// </summary>
        /// <returns></returns>
        public double GetVolume()
           
       {
            return 1.0 / 3.0 * a * h * H;
        }
    }
}
