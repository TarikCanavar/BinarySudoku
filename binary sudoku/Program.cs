using System;
using System.Threading;

namespace Binary_Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {

            int cx = 0;
            int cy = 0;
            ConsoleKeyInfo cki;

            int[,] board = new int[9, 9];
            int[,] newpiece = new int[3, 3];

            //board init
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    board[y, x] = -1;
                }
            }
            //Static screen parts
            Console.WriteLine("  1 2 3 4 5 6 7 8 9");
            Console.WriteLine(" +-----+-----+-----+");
            Console.WriteLine("1|     |     |     |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine("2|     |     |     |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine("3|     |     |     |");
            Console.WriteLine("+-----+-----+-----+");
            Console.WriteLine("4|     |     |     |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine("5|     |     |     |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine("6|     |     |     |");
            Console.WriteLine("+-----+-----+-----+");
            Console.WriteLine("7|     |     |     |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine("8|     |     |     |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine("9|     |     |     |");
            Console.WriteLine(" +-----+-----+-----+");
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Console.SetCursorPosition(2 * x + 2, 2 * y + 2);
                    if (board[x, y] == -1)
                        Console.Write(".");
                    else
                        Console.Write(board[x, y]);
                }
            }
            Random rand = new Random();
            int element = rand.Next(1, 11);
            int zeroOne;
            //newpiece init
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    newpiece[y, x] = -1;
                }
            }

            if (element == 1)
            {
                zeroOne = rand.Next(0, 2);
                newpiece[0, 0] = zeroOne;
            }
            else if (element == 2)
            {
                zeroOne = rand.Next(0, 2);
                newpiece[0, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[0, 1] = zeroOne;
            }
            else if (element == 3)
            {
                zeroOne = rand.Next(0, 2);
                newpiece[0, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[0, 1] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[0, 2] = zeroOne;
            }
            else if (element == 4)
            {
                zeroOne = rand.Next(0, 2);
                newpiece[0, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[0, 1] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[1, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[1, 1] = zeroOne;
            }
            else if (element == 5)
            {
                zeroOne = rand.Next(0, 2);
                newpiece[0, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[1, 0] = zeroOne;
            }
            else if (element == 6)
            {
                zeroOne = rand.Next(0, 2);
                newpiece[0, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[1, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[2, 0] = zeroOne;
            }
            else if (element == 7)
            {
                zeroOne = rand.Next(0, 2);
                newpiece[0, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[1, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[0, 1] = zeroOne;
            }
            else if (element == 8)
            {
                zeroOne = rand.Next(0, 2);
                newpiece[0, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[0, 1] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[1, 1] = zeroOne;
            }
            else if (element == 9)
            {
                zeroOne = rand.Next(0, 2);
                newpiece[0, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[1, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[1, 1] = zeroOne;
            }
            else if (element == 10)
            {
                zeroOne = rand.Next(0, 2);
                newpiece[0, 1] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[1, 0] = zeroOne;
                zeroOne = rand.Next(0, 2);
                newpiece[1, 1] = zeroOne;
            }
            while (true)
            {
                cki = Console.ReadKey(true);
                if (element == 1)
                {
                    if (cx < 8 && cki.Key == ConsoleKey.RightArrow) cx++;
                    if (cx > 0 && cki.Key == ConsoleKey.LeftArrow) cx--;
                    if (cy > 0 && cki.Key == ConsoleKey.UpArrow) cy--;
                    if (cy < 8 && cki.Key == ConsoleKey.DownArrow) cy++;
                }
                else if (element == 2)
                {
                    if (cx < 7 && cki.Key == ConsoleKey.RightArrow) cx++;
                    if (cx > 0 && cki.Key == ConsoleKey.LeftArrow) cx--;
                    if (cy > 0 && cki.Key == ConsoleKey.UpArrow) cy--;
                    if (cy < 8 && cki.Key == ConsoleKey.DownArrow) cy++;
                }
                else if (element == 3)
                {
                    if (cx < 6 && cki.Key == ConsoleKey.RightArrow) cx++;
                    if (cx > 0 && cki.Key == ConsoleKey.LeftArrow) cx--;
                    if (cy > 0 && cki.Key == ConsoleKey.UpArrow) cy--;
                    if (cy < 8 && cki.Key == ConsoleKey.DownArrow) cy++;
                }
                else if (element == 4)
                {
                    if (cx < 7 && cki.Key == ConsoleKey.RightArrow) cx++;
                    if (cx > 0 && cki.Key == ConsoleKey.LeftArrow) cx--;
                    if (cy > 0 && cki.Key == ConsoleKey.UpArrow) cy--;
                    if (cy < 7 && cki.Key == ConsoleKey.DownArrow) cy++;
                }
                else if (element == 5)
                {
                    if (cx < 8 && cki.Key == ConsoleKey.RightArrow) cx++;
                    if (cx > 0 && cki.Key == ConsoleKey.LeftArrow) cx--;
                    if (cy > 0 && cki.Key == ConsoleKey.UpArrow) cy--;
                    if (cy < 7 && cki.Key == ConsoleKey.DownArrow) cy++;
                }
                else if (element == 6)
                {
                    if (cx < 8 && cki.Key == ConsoleKey.RightArrow) cx++;
                    if (cx > 0 && cki.Key == ConsoleKey.LeftArrow) cx--;
                    if (cy > 0 && cki.Key == ConsoleKey.UpArrow) cy--;
                    if (cy < 6 && cki.Key == ConsoleKey.DownArrow) cy++;
                }
                else if (element == 7 || element == 8 || element == 9 || element == 10)
                {
                    if (cx < 7 && cki.Key == ConsoleKey.RightArrow) cx++;
                    if (cx > 0 && cki.Key == ConsoleKey.LeftArrow) cx--;
                    if (cy > 0 && cki.Key == ConsoleKey.UpArrow) cy--;
                    if (cy < 7 && cki.Key == ConsoleKey.DownArrow) cy++;
                }


                //print board
                for (int y = 0; y < 9; y++)
                {
                    for (int x = 0; x < 9; x++)
                    {
                        Console.SetCursorPosition(2 * x + 2, 2 * y + 2);
                        if (board[y, x] == -1)
                            Console.Write(".");
                        else
                            Console.Write(board[y, x]);
                    }
                }

                //print newpiece
                for (int y = 0; y < 3; y++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        Console.SetCursorPosition(2 * (cx + x) + 2, 2 * (cy + y) + 2);
                        if (newpiece[y, x] != -1)
                            Console.Write(newpiece[y, x]);
                    }
                }
                Console.SetCursorPosition(2 * cx + 2, 2 * cy + 2);
                if (cki.Key == ConsoleKey.Enter)
                {
                    if (cx == 4 && cy == 4 && (board[cy, cx] == 0 || board[cy, cx] == 1))
                    {
                        cx = 5;
                        cy = 4;
                    }
                    if (element == 1 && board[cy, cx] == -1)
                    {
                        board[cy, cx] = newpiece[0, 0];
                        cx = 4;
                        cy = 4;
                    }
                    else if (element == 2 && board[cy, cx] == -1 && board[cy, cx + 1] == -1)
                    {
                        board[cy, cx] = newpiece[0, 0];
                        board[cy, cx + 1] = newpiece[0, 1];
                        cx = 4;
                        cy = 4;
                    }
                    else if (element == 3 && board[cy, cx] == -1 && board[cy, cx + 1] == -1 && board[cy, cx + 2] == -1)
                    {
                        board[cy, cx] = newpiece[0, 0];
                        board[cy, cx + 1] = newpiece[0, 1];
                        board[cy, cx + 2] = newpiece[0, 2];
                        cx = 4;
                        cy = 4;

                    }
                    else if (element == 4 && board[cy, cx] == -1 && board[cy, cx + 1] == -1 && board[cy + 1, cx] == -1 && board[cy + 1, cx + 1] == -1)
                    {
                        board[cy, cx] = newpiece[0, 0];
                        board[cy, cx + 1] = newpiece[0, 1];
                        board[cy + 1, cx] = newpiece[1, 0];
                        board[cy + 1, cx + 1] = newpiece[1, 1];
                        cx = 4;
                        cy = 4;

                    }
                    else if (element == 5 && board[cy, cx] == -1 && board[cy + 1, cx] == -1)
                    {
                        board[cy, cx] = newpiece[0, 0];
                        board[cy + 1, cx] = newpiece[1, 0];
                        cx = 4;
                        cy = 4;

                    }
                    else if (element == 6 && board[cy, cx] == -1 && board[cy + 1, cx] == -1 && board[cy + 2, cx] == -1)
                    {
                        board[cy, cx] = newpiece[0, 0];
                        board[cy + 1, cx] = newpiece[1, 0];
                        board[cy + 2, cx] = newpiece[2, 0];
                        cx = 4;
                        cy = 4;

                    }
                    else if (element == 7 && board[cy, cx] == -1 && board[cy + 1, cx] == -1 && board[cy, cx + 1] == -1)
                    {
                        board[cy, cx] = newpiece[0, 0];
                        board[cy + 1, cx] = newpiece[1, 0];
                        board[cy, cx + 1] = newpiece[0, 1];
                        cx = 4;
                        cy = 4;

                    }
                    else if (element == 8 && board[cy, cx] == -1 && board[cy, cx + 1] == -1 && board[cy + 1, cx + 1] == -1)
                    {
                        board[cy, cx] = newpiece[0, 0];
                        board[cy, cx + 1] = newpiece[0, 1];
                        board[cy + 1, cx + 1] = newpiece[1, 1];
                        cx = 4;
                        cy = 4;

                    }
                    else if (element == 9 && board[cy, cx] == -1 && board[cy + 1, cx] == -1 && board[cy + 1, cx + 1] == -1)
                    {
                        board[cy, cx] = newpiece[0, 0];
                        board[cy + 1, cx] = newpiece[1, 0];
                        cx = 4;
                        cy = 4;

                    }
                    else if (element == 10 && board[cy, cx + 1] == -1 && board[cy + 1, cx] == -1 && board[cy + 1, cx + 1] == -1)
                    {
                        board[cy, cx + 1] = newpiece[0, 1];
                        board[cy + 1, cx] = newpiece[1, 0];
                        board[cy + 1, cx + 1] = newpiece[1, 1];
                        cx = 4;
                        cy = 4;
                    }

                    if (cx == 4 && cy == 4)
                    {
                        element = rand.Next(1, 11);
                        for (int y = 0; y < 3; y++)
                        {
                            for (int x = 0; x < 3; x++)
                            {
                                newpiece[y, x] = -1;
                            }
                        }
                        if (element == 1)
                        {
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 0] = zeroOne;
                        }
                        else if (element == 2)
                        {
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 1] = zeroOne;
                        }
                        else if (element == 3)
                        {
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 1] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 2] = zeroOne;
                        }
                        else if (element == 4)
                        {
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 1] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[1, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[1, 1] = zeroOne;
                        }
                        else if (element == 5)
                        {
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[1, 0] = zeroOne;
                        }
                        else if (element == 6)
                        {
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[1, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[2, 0] = zeroOne;
                        }
                        else if (element == 7)
                        {
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[1, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 1] = zeroOne;
                        }
                        else if (element == 8)
                        {
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 1] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[1, 1] = zeroOne;
                        }
                        else if (element == 9)
                        {
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[1, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[1, 1] = zeroOne;
                        }
                        else if (element == 10)
                        {
                            zeroOne = rand.Next(0, 2);
                            newpiece[0, 1] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[1, 0] = zeroOne;
                            zeroOne = rand.Next(0, 2);
                            newpiece[1, 1] = zeroOne;
                        }
                    }
                }


            }








        }
    }
}


