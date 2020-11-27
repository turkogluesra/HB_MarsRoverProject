using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB_MarsRoverProject
{
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Compass { get; set; }
        public List<int> Area { get; set; }        
        public List<string> Letters { get; set; }

        public Coordinates()
        {
            X = Y = 0;
            Compass = 'N';
            Area = new List<int>(new int[] { });
            Letters = new List<string>(new string[] { });
        }
    }
}
