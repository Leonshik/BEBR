using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_WORK
{
    internal class Metods
    {
        public void Char_map (int[,] arr)
        {
            char[,] char_map = new char[arr.GetLength(0)*3, arr.GetLength(1)*3];
            int sh_2;
            int X = 1;
            int Y = 1;
            for(int sh =0;sh<arr.GetLength(1);sh++)
            {
                X = 1;
                for(sh_2=0;sh_2<arr.GetLength(0);sh_2++)
                {
                    switch(arr[sh_2,sh])
                    {
                        case 1:
                            {
                                char_map[X, Y] = 'Q';

                                char_map[X, Y+1] = 'P';
                                char_map[X, Y-1] = 'P';
                                char_map[X + 1, Y] = 'Q';
                                char_map[X - 1, Y] = 'Q';

                                char_map[X + 1, Y + 1] = 'P';
                                char_map[X - 1, Y + 1] = 'P';
                                char_map[X + 1, Y - 1] = 'P';
                                char_map[X - 1, Y - 1] = 'P';
                                break;
                            }
                        case 2:
                            {
                                char_map[X, Y] = 'Q';
                                char_map[X, Y + 1] = 'Q';
                                char_map[X, Y - 1] = 'Q';
                                char_map[X + 1, Y] = 'P';
                                char_map[X - 1, Y] = 'P';
                                char_map[X + 1, Y + 1] = 'P';
                                char_map[X - 1, Y + 1] = 'P';
                                char_map[X + 1, Y - 1] = 'P';
                                char_map[X - 1, Y - 1] = 'P';
                                break;
                            }
                        case 3:
                            {
                                char_map[X, Y] = 'Q';

                                char_map[X, Y + 1] = 'P';
                                char_map[X, Y - 1] = 'Q';
                                char_map[X + 1, Y] = 'Q';
                                char_map[X - 1, Y] = 'P';

                                char_map[X + 1, Y + 1] = 'P';
                                char_map[X - 1, Y + 1] = 'P';
                                char_map[X + 1, Y - 1] = 'P';
                                char_map[X - 1, Y - 1] = 'P';
                                break;
                            }
                        case 4:
                            {
                                char_map[X, Y] = 'Q';
                                char_map[X, Y + 1] = 'Q';
                                char_map[X, Y - 1] = 'P';
                                char_map[X + 1, Y] = 'Q';
                                char_map[X - 1, Y] = 'P';

                                char_map[X + 1, Y + 1] = 'P';
                                char_map[X - 1, Y + 1] = 'P';
                                char_map[X + 1, Y - 1] = 'P';
                                char_map[X - 1, Y - 1] = 'P';
                                break;
                            }
                        case 5:
                            {
                                char_map[X, Y] = 'Q';
                                char_map[X, Y + 1] = 'P';
                                char_map[X, Y - 1] = 'Q';
                                char_map[X + 1, Y] = 'P';
                                char_map[X - 1, Y] = 'Q';

                                char_map[X + 1, Y + 1] = 'P';
                                char_map[X - 1, Y + 1] = 'P';
                                char_map[X + 1, Y - 1] = 'P';
                                char_map[X - 1, Y - 1] = 'P';
                                break;
                            }
                        case 6:
                            {
                                char_map[X, Y] = 'Q';
                                char_map[X, Y + 1] = 'Q';
                                char_map[X, Y - 1] = 'P';
                                char_map[X + 1, Y] = 'P';
                                char_map[X - 1, Y] = 'Q';

                                char_map[X + 1, Y + 1] = 'P';
                                char_map[X - 1, Y + 1] = 'P';
                                char_map[X + 1, Y - 1] = 'P';
                                char_map[X - 1, Y - 1] = 'P';
                                break;
                            }
                        case 7:
                            {
                                char_map[X, Y] = 'Q';

                                char_map[X, Y + 1] = 'Q';
                                char_map[X, Y - 1] = 'Q';
                                char_map[X + 1, Y] = 'Q';
                                char_map[X - 1, Y] = 'P';

                                char_map[X + 1, Y + 1] = 'P';
                                char_map[X - 1, Y + 1] = 'P';
                                char_map[X + 1, Y - 1] = 'P';
                                char_map[X - 1, Y - 1] = 'P';
                                break;
                            }
                        case 8:
                            {
                                char_map[X, Y] = 'Q';

                                char_map[X, Y + 1] = 'Q';
                                char_map[X, Y - 1] = 'Q';
                                char_map[X + 1, Y] = 'P';
                                char_map[X - 1, Y] = 'Q';

                                char_map[X + 1, Y + 1] = 'P';
                                char_map[X - 1, Y + 1] = 'P';
                                char_map[X + 1, Y - 1] = 'P';
                                char_map[X - 1, Y - 1] = 'P';
                                break;
                            }
                        case 9:
                            {
                                char_map[X, Y] = 'Q';

                                char_map[X, Y + 1] = 'P';
                                char_map[X, Y - 1] = 'Q';
                                char_map[X + 1, Y] = 'Q';
                                char_map[X - 1, Y] = 'Q';

                                char_map[X + 1, Y + 1] = 'P';
                                char_map[X - 1, Y + 1] = 'P';
                                char_map[X + 1, Y - 1] = 'P';
                                char_map[X - 1, Y - 1] = 'P';
                                break;
                            }
                        case 10:
                            {
                                char_map[X, Y] = 'Q';

                                char_map[X, Y + 1] = 'Q';
                                char_map[X, Y - 1] = 'P';
                                char_map[X + 1, Y] = 'Q';
                                char_map[X - 1, Y] = 'Q';

                                char_map[X + 1, Y + 1] = 'P';
                                char_map[X - 1, Y + 1] = 'P';
                                char_map[X + 1, Y - 1] = 'P';
                                char_map[X - 1, Y - 1] = 'P';
                                break;
                            }
                        case 11:
                            {
                                char_map[X, Y] = 'Q';

                                char_map[X, Y + 1] = 'Q';
                                char_map[X, Y - 1] = 'Q';
                                char_map[X + 1, Y] = 'Q';
                                char_map[X - 1, Y] = 'Q';

                                char_map[X + 1, Y + 1] = 'P';
                                char_map[X - 1, Y + 1] = 'P';
                                char_map[X + 1, Y - 1] = 'P';
                                char_map[X - 1, Y - 1] = 'P';
                                break;
                            }
                    }
                    X = X + 3;
                }
                Y = Y + 3;
            }
  
            for (int shsh = 0; shsh < char_map.GetLength(0); shsh++)
            {
                for (int shs = 0; shs < char_map.GetLength(1); shs++)
                {
                    Console.Write(char_map[shsh, shs]);
                }
                Console.WriteLine();
            }
        }
    }
}
