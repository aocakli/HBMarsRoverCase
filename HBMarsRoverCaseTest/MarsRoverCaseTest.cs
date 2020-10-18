using Microsoft.VisualStudio.TestTools.UnitTesting;

using HBMarsRoverCase;
using System.Collections.Specialized;

namespace HBMarsRoverCaseTest
{
    [TestClass]
    public class MarsRoverCaseTest
    {
        [TestMethod]
        public void TestMethodLMLM()
        {
            int maxX = 5;
            int maxY = 5;
            Rover rover = new Rover(1, 2, Directions.N);
            string moveOrder = "LMLMLMLMM";
            rover.startAction(maxX,maxY, moveOrder);
            string roverLocation = $"{rover.getPointX()} {rover.getPointY()} {rover.getDirection()}";
            string caseExpected = "1 3 N";
            string.Equals(roverLocation, caseExpected);
        }

        [TestMethod]
        public void TestMethodMRMR()
        {
            int maxX = 5;
            int maxY = 5;
            Rover rover = new Rover(3, 3, Directions.E);
            string moveOrder = "MMRMMRMRRM";
            rover.startAction(maxX, maxY, moveOrder);
            string roverLocation = $"{rover.getPointX()} {rover.getPointY()} {rover.getDirection()}";
            string caseExpected = "5 1 E";
            string.Equals(roverLocation, caseExpected);
        }
    }
}
