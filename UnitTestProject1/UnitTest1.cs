using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

namespace Conways //another change
{
    [TestClass]
    public class GameOfLife
    {
        [TestMethod]
        public void StillLife() //still life 

        {
            bool[,] StillLife = new bool[,] { { true, true }, { true, true } };
            Map board = new Map(StillLife);
            board.Tick();
            CollectionAssert.AreEqual(StillLife, board.GetBoard());
        }

        [TestMethod]
        public void Oscillator()
        {
            bool[,] oscillator = new bool[,] { { false, false, false }, { true, true, true }, { false, false, false } };
            Map board = new Map(oscillator);
            board.Tick();
            bool[,] expected = new bool[,] { { false, true, false }, { false, true, false }, { false, true, false } };
            CollectionAssert.AreEqual(expected, board.GetBoard());
        }

        [TestMethod]
        public void StillLife2()
        {
            bool[,] StillLife2 = new bool[,] { { false, true, true, false }, { true, false, false, true }, { false, true, true, false } };
            Map board = new Map(StillLife2);
            board.Tick();
            CollectionAssert.AreEqual(StillLife2, board.GetBoard());
        }

        [TestMethod]
        public void Oscillator2()
        {
            bool[,] oscillator2 = new bool[,] { { false, false, false, false }, {false, true, true, true }, { true, true, true, false }, { false, false, false, false } };
            Map board = new Map(oscillator2);
            board.Tick();
            bool[,] expected = new bool[,] { { false, false, true, false }, {true, false, false, true,  }, { true, false, false, true, }, { false, true, false, false } };
            CollectionAssert.AreEqual(expected, board.GetBoard());
        }

        [TestMethod]
        public void StillLife3()
        {
            bool[,] StillLife3 = new bool[,] { { false, true, true, false }, { true, false, false, true }, { false, true, false, true }, { false, false, true, false } };
            Map board = new Map(StillLife3);
            board.Tick();
            CollectionAssert.AreEqual(StillLife3, board.GetBoard());
        }

        [TestMethod]
        public void Oscillator3()
        {
            bool[,] oscillator3 = new bool[,] { { true, true, false, false }, { true, true, false, false }, { false, false, true, true }, { false, false, true, true } };
            Map board = new Map(oscillator3);
            board.Tick();
            bool[,] expected = new bool[,] { { true, true, false, false }, { true, false, false, false }, { false, false, false, true }, { false, false, true, true } };
            CollectionAssert.AreEqual(expected, board.GetBoard());
        }

        [TestMethod]
        public void StillLife4()
        {
            bool[,] StillLife4 = new bool[,] { { true, true, false }, { true, false, true }, { false, true, false } };
            Map board = new Map(StillLife4);
            board.Tick();
            CollectionAssert.AreEqual(StillLife4, board.GetBoard());
        }
    }
}
