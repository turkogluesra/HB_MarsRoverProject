using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB_MarsRoverProject
{    
    public interface IPositionControl
    {
        void FinalPositions(string letters, List<string> position, List<int> area); // Calculate the final position of rover robot
    }
}
