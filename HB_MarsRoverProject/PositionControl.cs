using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB_MarsRoverProject
{
    public class PositionControl : IPositionControl
    {
        Coordinates coordinates = new Coordinates();
        public void FinalPositions(string letters, List<string> position, List<int> area)
        {
            int l = letters.Length;
            int countUp = 0, countDown = 0;
            int countLeft = 0, countRight = 0;

            coordinates.X = Convert.ToInt32(position[0]);
            coordinates.Y = Convert.ToInt32(position[1]);
            coordinates.Compass = Convert.ToChar(position[2]);
            coordinates.Area = area;

            for (int i = 0; i < l; i++)
            {
                if (letters[i] == 'L')
                    switch (coordinates.Compass)
                    {
                        case 'N':
                            coordinates.Compass = 'W';
                            break;
                        case 'S':
                            coordinates.Compass = 'E';
                            break;
                        case 'E':
                            coordinates.Compass = 'N';
                            break;
                        case 'W':
                            coordinates.Compass = 'S';
                            break;
                        default:
                            Console.WriteLine($"Invalid Character {letters}");
                            Rover rover = new Rover();
                            rover.ReadPositionLetter(area);
                            break;
                    }

                else if (letters[i] == 'R')
                    switch (coordinates.Compass)
                    {
                        case 'N':
                            coordinates.Compass = 'E';
                            break;
                        case 'S':
                            coordinates.Compass = 'W';
                            break;
                        case 'E':
                            coordinates.Compass = 'S';
                            break;
                        case 'W':
                            coordinates.Compass = 'N';
                            break;
                        default:
                            Console.WriteLine($"Invalid Character {letters}");
                            break;
                    }

                else if (letters[i] == 'M')
                    switch (coordinates.Compass)
                    {
                        case 'N':
                            countUp++;
                            break;
                        case 'S':
                            countDown++;
                            break;
                        case 'E':
                            countRight++;
                            break;
                        case 'W':
                            countLeft++;
                            break;
                        default:
                            Console.WriteLine($"Invalid Character {letters}");
                            break;
                    }
            }

            coordinates.X += (countRight - countLeft);
            coordinates.Y += (countUp - countDown);

            if ((coordinates.X <= coordinates.Area[0] && coordinates.X >= 0) && (coordinates.Y <= coordinates.Area[1] && coordinates.Y >= 0))
            {
                Console.WriteLine($"{coordinates.X} {coordinates.Y} {coordinates.Compass}");
            }
            else
            {
                Console.WriteLine("Rover robot is out of boundaries");
                Environment.Exit(0);
            }
        }
    }
}
