using System;
using System.Collections.Generic;
using System.Linq;

namespace HB_MarsRoverProject
{
    public class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                Coordinates coordinates = new Coordinates();
                Rover rover = new Rover();
                List<int> area = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList(); //input of boundraies of axis
                coordinates.Area = area;
                rover.ReadPositionLetter(area);
                Console.WriteLine($"{coordinates.X} {coordinates.Y} {coordinates.Compass}"); //final position of robot
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
