using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB_MarsRoverProject
{
    public class Coordinates
    {
        public int X { get; set; } // X-axis
        public int Y { get; set; } //Y-axis
        public char Compass { get; set; } //North, South, East, West
        public List<int> Area { get; set; } //Rectangle of area       
        public List<string> Letters { get; set; } //Movements of rover robot

        public Coordinates()
        {
            X = Y = 0;
            Compass = 'N';
            Area = new List<int>(new int[] { });
            Letters = new List<string>(new string[] { });
        }
    }
}
