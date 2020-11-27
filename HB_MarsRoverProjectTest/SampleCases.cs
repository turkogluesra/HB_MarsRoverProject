using Microsoft.VisualStudio.TestTools.UnitTesting;
using HB_MarsRoverProject;
using System.Linq;
using System.Collections.Generic;
using System;
using Moq;

namespace HB_MarsRoverProjectTest
{
    [TestClass]
    public class SampleCases
    {

        [TestMethod]
        public void Case_LMLMLMLMM_MMRMMRMRRM()
        {
            List<string> position = null;  
            List<string> output = new List<string>();           

            List<Coordinates> coordinate = new List<Coordinates>();
            coordinate.Add(new Coordinates { X = 1, Y = 3, Compass= 'N' });
            coordinate.Add(new Coordinates { X = 3, Y = 3,  Compass= 'E' }); 

            Coordinates roverPosition = new Coordinates();
            roverPosition.Area.Add(5);
            roverPosition.Area.Add(5);
            roverPosition.Letters.Add("LMLMLMLMM");
            roverPosition.Letters.Add("MMRMMRMRRM");

            for (int i=0; coordinate.Count>i;i++ )
            {
                position = new List<string>(new string[] { coordinate[i].X.ToString(), coordinate[i].Y.ToString(), coordinate[i].Compass.ToString() });
                var _positionControl = new Mock<IPositionControl>();

                _positionControl.Setup(x=>x.FinalPositions(roverPosition.Letters[i], position, roverPosition.Area));

                output.Add(position[0] + ' ' + position[1] + ' ' + position[2]);
            }            

            var currentOutput = String.Join("\n", output.ToArray());
            var target = "1 3 N\n3 3 E";
            Assert.AreEqual(output, target); 
        }
    }
}
