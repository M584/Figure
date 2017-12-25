using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class parallelepiped : IFigure
    {
        /// <summary>
        /// Координаты X 
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Координаты Y
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Координаты Z
        /// </summary>
        public int Z { get; set; }

        /// <summary>
        /// Расчёт объёма параллелепипеда
        /// </summary>
        /// <returns></returns>
public double a { get
            {
                return _a;
                    }set
            { 
                    if (a < 0.0)
                    {
                        throw new ArgumentException();
                    }
                    else
                {
                    _a = value;
                }
            }
        }
        public double b { get
              { return _b;
    }
    set
            { 
                    if (b< 0.0)
                    {
                        throw new ArgumentException();
}
                    else
                {
                    _b = value;
                }
            }
        }
        public double c  { get
            { return _c;
                    }set
            { 
                    if (value < 0.0)
                    {
                        throw new ArgumentException();
                    }
                    else
                {
                    _c = value;
                }
            }
        }
        /// <summary>
        /// Расчет объёма параллелепипеда
        /// </summary>
        /// <returns></returns>

        public double GetVolume()
        { 
            return _a * b * c;
        }
    }
}

