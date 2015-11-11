using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConwaysGameOfLife
{
    public class Map
    {
        private bool[,] currentBoard;
        private bool[,] nextBoard;
        public Map(bool[,] newBoard)
        {
            currentBoard = newBoard;
            nextBoard = new bool[newBoard.GetLength(0), newBoard.GetLength(1)];
        }

        public void Tick()
        {
            for (int i = 0; i < currentBoard.GetLength(0); i++) //rows
            {
                for (int j = 0; j < currentBoard.GetLength(1); j++) //columns
                {
                    int alive = 0; //cells

                    try
                    {
                        if (currentBoard[i - 1, j - 1]) //doesnt need ==true
                        {
                            alive++;
                        }
                    }
                    catch { }

                    try
                    {
                        if (currentBoard[i - 1, j] == true)
                        {
                            alive++;
                        }
                    }
                    catch { }

                    try
                    {
                        if (currentBoard[i - 1, j + 1] == true)
                        {
                            alive++;
                        }
                    }
                    catch { }

                    try
                    {
                        if (currentBoard[i, j + 1] == true)
                        {
                            alive++;
                        }

                    }
                    catch { }

                    try
                    {
                        if (currentBoard[i + 1, j + 1] == true)
                        {
                            alive++;
                        }
                    }
                    catch { }

                    try
                    {
                        if (currentBoard[i + 1, j] == true)
                        {
                            alive++;
                        }
                    }
                    catch { }

                    try
                    {
                        if (currentBoard[i + 1, j - 1] == true)
                        {
                            alive++;
                        }
                    }
                    catch { }

                    try
                    {
                        if (currentBoard[i, j - 1] == true)
                        {
                            alive++;
                        }
                    }
                    catch { }


                    if (currentBoard[i, j] == true)
                    {
                        if (alive < 2)
                        {
                            nextBoard[i, j] = false;
                        }
                        else if (alive < 4)
                        {
                            nextBoard[i, j] = true;
                        }
                        else
                        {
                            nextBoard[i, j] = false;
                        }
                    }
                    else
                    {
                        if (alive == 3)
                        {
                            nextBoard[i, j] = true;
                        }
                        else
                        {
                            nextBoard[i, j] = false;
                        }
                    }
                 }
            }
            currentBoard = nextBoard;
        }


        public bool[,] GetBoard()
       {
            return currentBoard;
       }
    }
}
