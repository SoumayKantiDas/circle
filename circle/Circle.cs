using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    public class Circle
    {
        public double Radious { get; set; }
        public double FindArea()
        {
              return Math.PI * Radious * Radious;
        }
        public double Findcircumestance()
        {
            return Math.PI * 2 * Radious;
        }

    }
}
