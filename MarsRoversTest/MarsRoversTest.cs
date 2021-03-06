﻿using MarsRovers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MarsRoversTest
{
    [TestClass]
    public class MarsRoversTest
    {
        [TestMethod]
        public void DeployRoversTest()
        {
            IPlateau area = new Plateau("5 5");
            RoverSet searcherTeam = new RoverSet(area);

            searcherTeam.AddRover("1 2 N", "LMLMLMLMM");
            searcherTeam.AddRover("3 3 E", "MMRMMRMRRM");

            Assert.IsTrue(searcherTeam.Count == 2);

            IRover first = searcherTeam[0];
            IRover second = searcherTeam[1];

            Assert.IsNotNull(first);
            Assert.IsNotNull(second);
        }

        [TestMethod]
        public void DeployRoversAndTestCoordinates()
        {
            IPlateau area = new Plateau("5 5");
            RoverSet roverTeam = new RoverSet(area);

            roverTeam.AddRover("1 2 N", "LMLMLMLMM");
            roverTeam.AddRover("3 3 E", "MMRMMRMRRM");

            IRover first = roverTeam[0];
            IRover second = roverTeam[1];

            Assert.IsTrue(first.XCoordinate == 1);
            Assert.IsTrue(first.YCoordinate == 3);
            Assert.IsTrue(first.Direction == Common.Direction.North);

            Assert.IsTrue(second.XCoordinate == 5);
            Assert.IsTrue(second.YCoordinate == 1);
            Assert.IsTrue(second.Direction == Common.Direction.East);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DeployRoversAndTestCoordinatesOutOfRange()
        {
            IPlateau area = new Plateau("5 5");
            RoverSet roverTeam = new RoverSet(area);
            roverTeam.AddRover("1 2 N", "MMMMMMMM");
        }
    }
}
