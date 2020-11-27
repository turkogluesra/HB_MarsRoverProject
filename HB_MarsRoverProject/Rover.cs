using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB_MarsRoverProject
{
    public class Rover
    {
        Coordinates coordinates = new Coordinates();
        IPositionControl _positionControl = new PositionControl();
        public void ReadPositionLetter(List<int> area)
        {
            var position = Console.ReadLine().Trim().Split(' ').Select(x => x).ToList(); // starting point of robot
            var letters = Console.ReadLine().ToUpper(); // target movements of robot

            _positionControl.FinalPositions(letters, position, area);
            ReadPositionLetter(area); //recursive search of positions
        }       
    }
}
