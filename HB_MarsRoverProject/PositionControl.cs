using System;
using System.Collections.Generic;

namespace HB_MarsRoverProject
{
    public class PositionControl : IPositionControl
    {
        Coordinates coordinates = new Coordinates();
        public void FinalPositions(string letters, List<string> position, List<int> area)
        {
            int l = letters.Length;
            int countUp = 0, countDown = 0; 
            int countLeft = 0, countRight = 0; // count to total movement of Rover Robot

            coordinates.X = Convert.ToInt32(position[0]);
            coordinates.Y = Convert.ToInt32(position[1]);
            coordinates.Compass = Convert.ToChar(position[2]);
            coordinates.Area = area;

            for (int i = 0; i < l; i++)
            {
                if (letters[i] == 'L') // Logic of this switch-case (e.g  if robot turns left from current compass direction sets to left side of compass direction and if "move" command read from letters counter increases where the compass shows )
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
                            Console.WriteLine($"Invalid input -> {letters} ");
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
                            Console.WriteLine($"Invalid input -> {letters}");
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
                            Console.WriteLine($"Invalid input -> {letters}");
                            break;
                    }
            }

            coordinates.X += (countRight - countLeft); //final coordinate on x-axis
            coordinates.Y += (countUp - countDown); //final coordinate on y-axis

            if ((coordinates.X <= coordinates.Area[0] || coordinates.X >= 0) || (coordinates.Y <= coordinates.Area[1] || coordinates.Y >= 0)) // robot must be between boundaries
            {
                Console.WriteLine($"{coordinates.X} {coordinates.Y} {coordinates.Compass}");
            }
            else
            {
                Console.WriteLine("Rover robot out of boundaries");
                Environment.Exit(0);
            }
        }
    }
}
