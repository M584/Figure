using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sphere: IFigure
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


        private double _radius;

        /// <summary>
        /// При вычислении радиуса...
        /// </summary>
        public double Radius { get
            {
                return _radius;
            } set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _radius = value;
                }
            } }

        /// <summary>
        /// Расчет объёма сферы.
        /// </summary>
        /// <returns></returns>
        public double GetVolume()
        {
            return 3.0 / 4.0 * Math.PI * Radius * Radius * Radius;
        }
    }






