// test
using System;
namespace F_WORK
{
    class Programm
    {
        static void Main(string[] args)
        {
            {
                /*
                Char[,] testy;
                int[,] test = new int[,]
                {
                  {3,4,5,6,7},
                  {8,9,10,11,2},
                  {1,2,1,2,1}
                };
                Metods metods = new Metods();
               testy = metods.Char_map(test);
                for(int shsh =0;shsh<testy.GetLength(0);shsh++)
                {
                    for(int shs=0;shs<testy.GetLength(1);shs++)
                    {
                        Console.Write(testy[shsh, shs]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("всё");
                Console.ReadKey();
                {

                   ConsoleKeyInfo KAKA;
                   for(int ror =0; ror !=20;ror++)
                   {
                       KAKA = Console.ReadKey();
                       Console.WriteLine(KAKA.KeyChar);
                   }
                   */
            }
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int kx, ky;
            int[] prod_map = new int[4];
            int max_X_map = 0;
            int max_Y_map = 0;
            Random random = new Random();
            Metods metods = new Metods();
            int itog_location_shablon = 0;
            int itog_shablon = 0;
            //введение данных
            while (max_X_map == 0 && max_Y_map == 0)
            {
                Console.WriteLine("Введите массив");
                Console.Write("X - ");
                int.TryParse(Console.ReadLine(), out max_X_map);
                Console.Write("Y - ");
                int.TryParse(Console.ReadLine(), out max_Y_map);
            }
            int[,] map = new int[max_X_map, max_Y_map];
            max_X_map = max_X_map - 1;
            max_Y_map = max_Y_map - 1;
            //определение входа
            ky = max_Y_map;
            kx = random.Next(0, max_X_map + 1);
            map[kx, ky] = random.Next(1, 12);
            if (map[kx, ky] == 3 && kx == 0)
            {
                map[kx, ky] = 4;
            }
            if (map[kx, ky] == 4 && kx == max_X_map)
            {
                map[kx, ky] = 3;
            }
            int peremen = 0;
            int peremen_2 = 0;
            int peremen_3 = 0;
            int peremen_4 = 0;
            int sh;
            int sh_2 = 0;
            int per = 0;
            int smena = 0;
            int smena_2 = 0;
            //получаем готовый путь
            while (peremen_3 != 1)
            {
                per = 0;
                peremen = 0;
                peremen_2 = 0;
                //получение информации окружения взависимости от положения проверяемой клетки
                //углы
                if (kx == 0 && ky == 0)//правый верхний угол
                {
                    prod_map[0] = 0;
                    prod_map[1] = 0;

                    if (map[kx + 1, ky] == 0)
                    {
                        prod_map[2] = 1;
                    }
                    else { prod_map[2] = 0; }

                    if (map[kx, ky + 1] == 0)
                    {
                        prod_map[3] = 1;
                    }
                    else { prod_map[3] = 0; }
                }
                else if (kx == max_X_map && ky == max_Y_map)//левый нижний угол
                {
                    prod_map[2] = 0;
                    prod_map[3] = 0;

                    if (map[kx - 1, ky] == 0)
                    {
                        prod_map[0] = 1;
                    }
                    else { prod_map[0] = 0; }

                    if (map[kx, ky - 1] == 0)
                    {
                        prod_map[1] = 1;
                    }
                    else { prod_map[1] = 0; }
                }
                else if (kx == max_X_map && ky == 0)//левый верхний угол
                {
                    prod_map[1] = 0;
                    prod_map[2] = 0;

                    if (map[kx - 1, ky] == 0)
                    {
                        prod_map[0] = 1;
                    }
                    else { prod_map[0] = 0; }

                    if (map[kx, ky + 1] == 0)
                    {
                        prod_map[3] = 1;
                    }
                    else { prod_map[3] = 0; }
                }
                else if (kx == 0 && ky == max_Y_map)//правый нижний угол
                {
                    prod_map[0] = 0;
                    prod_map[3] = 0;

                    if (map[kx + 1, ky] == 0)
                    {
                        prod_map[2] = 1;
                    }
                    else { prod_map[2] = 0; }

                    if (map[kx, ky - 1] == 0)
                    {
                        prod_map[1] = 1;
                    }
                    else { prod_map[1] = 0; }
                }
                //края
                else if (kx == 0)//право
                {
                    prod_map[0] = 0;

                    if (map[kx, ky - 1] == 0)
                    {
                        prod_map[1] = 1;
                    }
                    else { prod_map[1] = 0; }

                    if (map[kx + 1, ky] == 0)
                    {
                        prod_map[2] = 1;
                    }
                    else { prod_map[2] = 0; }

                    if (map[kx, ky + 1] == 0)
                    {
                        prod_map[3] = 1;
                    }
                    else { prod_map[3] = 0; }
                }
                else if (kx == max_X_map)//лево
                {
                    prod_map[2] = 0;

                    if (map[kx, ky - 1] == 0)
                    {
                        prod_map[1] = 1;
                    }
                    else { prod_map[1] = 0; }

                    if (map[kx - 1, ky] == 0)
                    {
                        prod_map[0] = 1;
                    }
                    else { prod_map[0] = 0; }

                    if (map[kx, ky + 1] == 0)
                    {
                        prod_map[3] = 1;
                    }
                    else { prod_map[3] = 0; }
                }
                else if (ky == max_Y_map)//низ
                {
                    prod_map[3] = 0;

                    if (map[kx, ky - 1] == 0)
                    {
                        prod_map[1] = 1;
                    }
                    else { prod_map[1] = 0; }

                    if (map[kx - 1, ky] == 0)
                    {
                        prod_map[0] = 1;
                    }
                    else { prod_map[0] = 0; }

                    if (map[kx + 1, ky] == 0)
                    {
                        prod_map[2] = 1;
                    }
                    else { prod_map[2] = 0; }
                }
                else if (ky == 0)//верх
                {
                    prod_map[1] = 0;

                    if (map[kx, ky + 1] == 0)
                    {
                        prod_map[3] = 1;
                    }
                    else { prod_map[3] = 0; }

                    if (map[kx - 1, ky] == 0)
                    {
                        prod_map[0] = 1;
                    }
                    else { prod_map[0] = 0; }

                    if (map[kx + 1, ky] == 0)
                    {
                        prod_map[2] = 1;
                    }
                    else { prod_map[2] = 0; }
                }
                //Середина
                else if (kx > 0 && ky > 0 && kx < max_X_map && ky < max_Y_map)
                {
                    if (map[kx, ky + 1] == 0)
                    {
                        prod_map[3] = 1;
                    }
                    else { prod_map[3] = 0; }

                    if (map[kx, ky - 1] == 0)
                    {
                        prod_map[1] = 1;
                    }
                    else { prod_map[1] = 0; }

                    if (map[kx - 1, ky] == 0)
                    {
                        prod_map[0] = 1;
                    }
                    else { prod_map[0] = 0; }

                    if (map[kx + 1, ky] == 0)
                    {
                        prod_map[2] = 1;
                    }
                    else { prod_map[2] = 0; }
                }
                //входы шаблонов
                {
                    //условия которые проверяют шаблон клетки и взависимости от шаьлона ставит гарантированную "занятость" клетки окружения
                    //перекрёсток
                    if (map[kx, ky] == 11)
                    {

                    }
                    //вертикаль
                    if (map[kx, ky] == 1)
                    {
                        prod_map[0] = 0;
                        prod_map[2] = 0;
                    }
                    //горизонталь
                    if (map[kx, ky] == 2)
                    {
                        prod_map[1] = 0;
                        prod_map[3] = 0;
                    }
                    //Поворот_с_низа_налево
                    if (map[kx, ky] == 3)
                    {
                        prod_map[1] = 0;
                        prod_map[2] = 0;
                    }
                    // Поворот_с_низа_направо
                    if (map[kx, ky] == 4)
                    {
                        prod_map[1] = 0;
                        prod_map[0] = 0;
                    }
                    // Поворот_с_верха_налево
                    if (map[kx, ky] == 5)
                    {
                        prod_map[3] = 0;
                        prod_map[2] = 0;
                    }
                    //Поворот_с_верха_направо
                    if (map[kx, ky] == 6)
                    {
                        prod_map[3] = 0;
                        prod_map[0] = 0;
                    }
                    // Т_основа_низ
                    if (map[kx, ky] == 7)
                    {
                        prod_map[1] = 0;
                    }
                    //Т_основа_верх
                    if (map[kx, ky] == 8)
                    {
                        prod_map[3] = 0;
                    }
                    // Т_основа_лево
                    if (map[kx, ky] == 9)
                    {
                        prod_map[2] = 0;
                    }
                    // Т_основа_право
                    if (map[kx, ky] == 10)
                    {
                        prod_map[0] = 0;
                    }
                    //тупики не трогаю
                }
                //генерация места шаблона с учитыванием окружения
                while (peremen != 1)
                {
                    itog_location_shablon = random.Next(0, 4);
                    switch (itog_location_shablon)
                    {
                        case 0:
                            {
                                if (prod_map[0] == 1)
                                {
                                    peremen = 1;
                                }
                                break;
                            }
                        case 1:
                            {
                                if (prod_map[1] == 1)
                                {
                                    peremen = 1;
                                }
                                break;
                            }
                        case 2:
                            {
                                if (prod_map[2] == 1)
                                {
                                    peremen = 1;
                                }
                                break;
                            }
                        case 3:
                            {
                                if (prod_map[3] == 1)
                                {
                                    peremen = 1;
                                }
                                break;
                            }
                    }
                    Console.Write(prod_map[0]);
                    Console.Write(prod_map[1]);
                    Console.Write(prod_map[2]);
                    Console.Write(prod_map[3]);
                    Console.WriteLine();
                }
                //генерация максимально подходящего шаблона
                while (peremen_2 != 1)
                {
                    itog_shablon = random.Next(1, 12);
                    switch (itog_shablon)
                    {
                        case 11:
                            {
                                peremen_2 = 1;
                                break;
                            }
                        case 1:
                            {
                                if (itog_location_shablon == 1)
                                {
                                    if (ky != 1)     //!!!
                                    {
                                        peremen_2 = 1;
                                    }
                                }
                                if (itog_location_shablon == 3)
                                {
                                    if (ky + 1 != max_Y_map)     //!!!
                                    {
                                        peremen_2 = 1;
                                    }
                                }

                                break;
                            }
                        case 2:
                            {
                                if (itog_location_shablon == 0)
                                {
                                    if (kx != 1)     //!!!
                                    {
                                        peremen_2 = 1;
                                    }
                                }
                                if (itog_location_shablon == 2)
                                {
                                    if (kx + 1 != max_X_map)     //!!!
                                    {
                                        peremen_2 = 1;
                                    }
                                }
                                break;
                            }
                        case 3:
                            {
                                if (itog_location_shablon == 1)
                                {
                                    if (kx > 0)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                    {
                                        if (map[kx - 1, ky - 1] == 0)
                                        {
                                            peremen_2 = 1;
                                        }
                                    }
                                }
                                break;
                            }
                        case 4:
                            {
                                if (itog_location_shablon == 1)
                                {
                                    if (kx < max_X_map)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                    {
                                        if (map[kx + 1, ky - 1] == 0)
                                        {
                                            peremen_2 = 1;
                                        }
                                    }
                                }
                                break;
                            }
                        case 5:
                            {
                                if (itog_location_shablon == 2)
                                {
                                    if (ky > 0)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                    {
                                        if (map[kx + 1, ky - 1] == 0)
                                        {
                                            peremen_2 = 1;
                                        }
                                    }
                                }
                                else if (itog_location_shablon == 3)
                                {
                                    if (kx > 0)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                    {
                                        if (map[kx - 1, ky + 1] == 0)
                                        {
                                            peremen_2 = 1;
                                        }
                                    }
                                }
                                break;
                            }
                        case 6:
                            {
                                if (itog_location_shablon == 0)
                                {
                                    if (ky > 0)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                    {
                                        if (map[kx - 1, ky - 1] == 0)
                                        {
                                            peremen_2 = 1;
                                        }
                                    }
                                }
                                else if (itog_location_shablon == 3)
                                {
                                    if (kx < max_X_map)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                    {
                                        if (map[kx + 1, ky + 1] == 0)
                                        {
                                            peremen_2 = 1;
                                        }
                                    }
                                }
                                break;
                            }
                        case 7:
                            {
                                if (itog_location_shablon == 1)
                                {
                                    peremen_2 = 1;
                                }
                                break;
                            }
                        case 8:
                            {
                                if (itog_location_shablon == 0)///////////////////////////////////////////////////////////////////////////////////
                                {
                                    if (kx - 1 == 0 && ky > 0)
                                    {
                                        if (map[kx - 1, ky - 1] == 0)
                                        {
                                            peremen_2 = 1;
                                        }
                                    }
                                    else if (kx > 1)
                                    {
                                        peremen_2 = 1;
                                    }
                                }

                                else if (itog_location_shablon == 2)
                                {
                                    if (kx + 1 == max_X_map && ky > 0)
                                    {
                                        if (map[kx + 1, ky - 1] == 0)
                                        {
                                            peremen_2 = 1;
                                        }
                                    }
                                    else if (kx < max_X_map - 1)
                                    {
                                        peremen_2 = 1;
                                    }
                                }

                                else if (itog_location_shablon == 3)
                                {
                                    peremen_2 = 1;
                                }
                                if (ky == 0 && (itog_location_shablon == 0 || itog_location_shablon == 2))
                                {
                                    peremen_2 = 1;
                                }
                                break;
                            }
                        case 9:
                            {
                                if (itog_location_shablon == 3)///////////////////////////////////////////////////////////////////////////////////
                                {
                                    if (!(kx == 0 && ky + 1 == max_Y_map))
                                    {
                                        peremen_2 = 1;
                                    }
                                }
                                else if (itog_location_shablon == 1)
                                {
                                    peremen_2 = 1;
                                }
                                else if (itog_location_shablon == 2)
                                {
                                    peremen_2 = 1;
                                }
                                break;
                            }
                        case 10:
                            {
                                if (itog_location_shablon == 3)///////////////////////////////////////////////////////////////////////////////////
                                {
                                    if (!(kx == max_X_map && ky + 1 == max_Y_map))
                                    {
                                        peremen_2 = 1;
                                    }
                                }
                                else if (itog_location_shablon == 1)
                                {
                                    peremen_2 = 1;
                                }
                                else if (itog_location_shablon == 0)
                                {
                                    peremen_2 = 1;
                                }
                                break;
                            }
                    }

                }
                // зделать условие которое передвигает координаты проверяемой клетки взависимости от иотогового положения сежегоо шаблона и потом зациклить
                switch (itog_location_shablon)
                {
                    case 0:
                        {
                            map[kx - 1, ky] = itog_shablon;
                            kx = kx - 1;
                            break;
                        }
                    case 1:
                        {
                            map[kx, ky - 1] = itog_shablon;
                            ky = ky - 1;
                            break;
                        }
                    case 2:
                        {
                            map[kx + 1, ky] = itog_shablon;
                            kx = kx + 1;
                            break;
                        }
                    case 3:
                        {
                            map[kx, ky + 1] = itog_shablon;
                            ky = ky + 1;
                            break;
                        }
                }
                //цикл проверяющий верхнюю строку на наличие "выходных шаблонов"
                for (sh = 0; sh <= max_X_map; sh++)
                {
                    if (map[sh, 0] == 11 || map[sh, 0] == 6 || map[sh, 0] == 5 || map[sh, 0] == 8 || map[sh, 0] == 9 || map[sh, 0] == 10 || map[sh, 0] == 1)
                    {
                        peremen_3 = 1;
                    }
                }
                for (int t = 0; t < map.GetLength(1); t++)
                {
                    for (int f = 0; f < map.GetLength(0); f++)
                    {
                        Console.Write(map[f, t]);
                    }
                    Console.WriteLine();
                }
                metods.Char_map(map);
                if(prod_map[0]==0&& prod_map[1] == 0 && prod_map[2] == 0 && prod_map[3] == 0 )
                {
                    for(smena=0;smena <map.GetLength (1);smena++)
                    {
                        for(smena_2 =0;smena_2 <map.GetLength (0);smena_2++)
                        {
                            if(map[smena_2,smena]!=0)
                            {
                                kx = smena_2;
                                ky = smena;
                                smena_2 = map.GetLength(0);
                                smena = map.GetLength(1);
                            }
                        }
                    }
                }
            }
            //заполнение
            
            for (int t = 0; t < map.GetLength(1); t++)
            {
                for (int f = 0; f < map.GetLength(0); f++)
                {
                    Console.WriteLine("t - " + t);
                    Console.WriteLine("f - " + f);
                    kx = f;
                    ky = t;
                    peremen_4 = 0;
                    if (map[f,t]!=0)//
                    {
                        Console.WriteLine("Переменная - "+f+" , "+t+" занята");
                        while (peremen_4 != 1)
                        {
                            if (kx == 0 && ky == 0)//правый верхний угол
                            {
                                prod_map[0] = 0;
                                prod_map[1] = 0;
                                if (map[kx + 1, ky] == 0)
                                {
                                    prod_map[2] = 1;
                                }
                                else { prod_map[2] = 0; }
                                if (map[kx, ky + 1] == 0)
                                {
                                    prod_map[3] = 1;
                                }
                                else { prod_map[3] = 0; }
                            }
                            else if (kx == max_X_map && ky == max_Y_map)//левый нижний угол
                            {
                                prod_map[2] = 0;
                                prod_map[3] = 0;
                                if (map[kx - 1, ky] == 0)
                                {
                                    prod_map[0] = 1;
                                }
                                else { prod_map[0] = 0; }
                                if (map[kx, ky - 1] == 0)
                                {
                                    prod_map[1] = 1;
                                }
                                else { prod_map[1] = 0; }
                            }
                            else if (kx == max_X_map && ky == 0)//левый верхний угол
                            {
                                prod_map[1] = 0;
                                prod_map[2] = 0;
                                if (map[kx - 1, ky] == 0)
                                {
                                    prod_map[0] = 1;
                                }
                                else { prod_map[0] = 0; }
                                if (map[kx, ky + 1] == 0)
                                {
                                    prod_map[3] = 1;
                                }
                                else { prod_map[3] = 0; }
                            }
                            else if (kx == 0 && ky == max_Y_map)//правый нижний угол
                            {
                                prod_map[0] = 0;
                                prod_map[3] = 0;
                                if (map[kx + 1, ky] == 0)
                                {
                                    prod_map[2] = 1;
                                }
                                else { prod_map[2] = 0; }
                                if (map[kx, ky - 1] == 0)
                                {
                                    prod_map[1] = 1;
                                }
                                else { prod_map[1] = 0; }
                            }
                            //края
                            else if (kx == 0)//право
                            {
                                prod_map[0] = 0;
                                if (map[kx, ky - 1] == 0)
                                {
                                    prod_map[1] = 1;
                                }
                                else { prod_map[1] = 0; }
                                if (map[kx + 1, ky] == 0)
                                {
                                    prod_map[2] = 1;
                                }
                                else { prod_map[2] = 0; }
                                if (map[kx, ky + 1] == 0)
                                {
                                    prod_map[3] = 1;
                                }
                                else { prod_map[3] = 0; }
                            }
                            else if (kx == max_X_map)//лево
                            {
                                prod_map[2] = 0;
                                if (map[kx, ky - 1] == 0)
                                {
                                    prod_map[1] = 1;
                                }
                                else { prod_map[1] = 0; }
                                if (map[kx - 1, ky] == 0)
                                {
                                    prod_map[0] = 1;
                                }
                                else { prod_map[0] = 0; }
                                if (map[kx, ky + 1] == 0)
                                {
                                    prod_map[3] = 1;
                                }
                                else { prod_map[3] = 0; }
                            }
                            else if (ky == max_Y_map)//низ
                            {
                                prod_map[3] = 0;
                                if (map[kx, ky - 1] == 0)
                                {
                                    prod_map[1] = 1;
                                }
                                else { prod_map[1] = 0; }
                                if (map[kx - 1, ky] == 0)
                                {
                                    prod_map[0] = 1;
                                }
                                else { prod_map[0] = 0; }
                                if (map[kx + 1, ky] == 0)
                                {
                                    prod_map[2] = 1;
                                }
                                else { prod_map[2] = 0; }
                            }
                            else if (ky == 0)//верх
                            {
                                prod_map[1] = 0;
                                if (map[kx, ky + 1] == 0)
                                {
                                    prod_map[3] = 1;
                                }
                                else { prod_map[3] = 0; }
                                if (map[kx - 1, ky] == 0)
                                {
                                    prod_map[0] = 1;
                                }
                                else { prod_map[0] = 0; }
                                if (map[kx + 1, ky] == 0)
                                {
                                    prod_map[2] = 1;
                                }
                                else { prod_map[2] = 0; }
                            }
                            //Середина
                            else if (kx > 0 && ky > 0 && kx < max_X_map && ky < max_Y_map)
                            {
                                if (map[kx, ky + 1] == 0)
                                {
                                    prod_map[3] = 1;
                                }
                                else { prod_map[3] = 0; }
                                if (map[kx, ky - 1] == 0)
                                {
                                    prod_map[1] = 1;
                                }
                                else { prod_map[1] = 0; }
                                if (map[kx - 1, ky] == 0)
                                {
                                    prod_map[0] = 1;
                                }
                                else { prod_map[0] = 0; }
                                if (map[kx + 1, ky] == 0)
                                {
                                    prod_map[2] = 1;
                                }
                                else { prod_map[2] = 0; }
                            }
                            Console.WriteLine("Окружение : " + prod_map[0] + prod_map[1] + prod_map[2] + prod_map[3]+" после сегмента 1");
                            //входы шаблонов
                            {
                                if (map[kx, ky] == 11)
                                {
                                }
                                //вертикаль
                                if (map[kx, ky] == 1)
                                {
                                    prod_map[0] = 0;
                                    prod_map[2] = 0;
                                }
                                //горизонталь
                                if (map[kx, ky] == 2)
                                {
                                    prod_map[1] = 0;
                                    prod_map[3] = 0;
                                }
                                //Поворот_с_низа_налево
                                if (map[kx, ky] == 3)
                                {
                                    prod_map[1] = 0;
                                    prod_map[2] = 0;
                                }
                                // Поворот_с_низа_направо
                                if (map[kx, ky] == 4)
                                {
                                    prod_map[1] = 0;
                                    prod_map[0] = 0;
                                }
                                // Поворот_с_верха_налево
                                if (map[kx, ky] == 5)
                                {
                                    prod_map[3] = 0;
                                    prod_map[2] = 0;
                                }
                                //Поворот_с_верха_направо
                                if (map[kx, ky] == 6)
                                {
                                    prod_map[3] = 0;
                                    prod_map[0] = 0;
                                }
                                // Т_основа_низ
                                if (map[kx, ky] == 7)
                                {
                                    prod_map[1] = 0;
                                }
                                //Т_основа_верх
                                if (map[kx, ky] == 8)
                                {
                                    prod_map[3] = 0;
                                }
                                // Т_основа_лево
                                if (map[kx, ky] == 9)
                                {
                                    prod_map[2] = 0;
                                }
                                // Т_основа_право
                                if (map[kx, ky] == 10)
                                {
                                    prod_map[0] = 0;
                                }
                            }
                            Console.WriteLine("Окружение : " + prod_map[0] + prod_map[1] + prod_map[2] + prod_map[3] + " после сегмента 2");
                            //есть окружение
                            if(prod_map[0] == 0 && prod_map[1] == 0 && prod_map[2] == 0 && prod_map[3] == 0)
                            {
                                peremen_4 = 1;
                            }
                            else
                            {
                                //problems_problems_problems_problems_problems_problems_problems_problems_problems_//problems_problems_problems_problems_problems_problems_problems_problems_problems_
                                peremen = 0;
                                while (peremen != 1)
                                {
                                    itog_location_shablon = random.Next(0, 4);
                                    switch (itog_location_shablon)
                                    {
                                        case 0:
                                            {
                                                if (prod_map[0] == 1)
                                                {
                                                    peremen = 1;
                                                }
                                                break;
                                            }
                                        case 1:
                                            {
                                                if (prod_map[1] == 1)
                                                {
                                                    peremen = 1;
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                if (prod_map[2] == 1)
                                                {
                                                    peremen = 1;
                                                }
                                                break;
                                            }
                                        case 3:
                                            {
                                                if (prod_map[3] == 1)
                                                {
                                                    peremen = 1;
                                                }
                                                break;
                                            }
                                    }
                                    Console.Write(prod_map[0]);
                                    Console.Write(prod_map[1]);
                                    Console.Write(prod_map[2]);
                                    Console.Write(prod_map[3]);
                                    Console.WriteLine();
                                }
                                //.
                                while (peremen_2 != 1)
                                {
                                    itog_shablon = random.Next(1, 12);
                                    switch (itog_shablon)
                                    {
                                        case 11:
                                            {
                                                peremen_2 = 1;
                                                break;
                                            }
                                        case 1:
                                            {
                                                if (itog_location_shablon == 1)
                                                {
                                                    if (ky != 1)
                                                    {
                                                        if (ky - 2 == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                if (itog_location_shablon == 3)
                                                {
                                                    if (ky + 1 != max_Y_map)
                                                    {
                                                        if (ky + 2 == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                if (itog_location_shablon == 0)
                                                {
                                                    if (kx != 1)
                                                    {
                                                        if (kx - 2 == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                if (itog_location_shablon == 2)
                                                {
                                                    if (kx + 1 != max_X_map)
                                                    {
                                                        if (kx + 2 == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                break;
                                            }
                                        case 3:
                                            {
                                                if (itog_location_shablon == 1)
                                                {
                                                    if (kx > 0)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                                    {
                                                        if (map[kx - 1, ky - 1] == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                if (itog_location_shablon == 2)
                                                {
                                                    if (ky != max_Y_map)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                                    {
                                                        if (map[kx + 1, ky + 1] == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                break;
                                            }
                                        case 4:
                                            {
                                                if (itog_location_shablon == 1)
                                                {
                                                    if (kx < max_X_map)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                                    {
                                                        if (map[kx + 1, ky - 1] == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                if (itog_location_shablon == 0)
                                                {
                                                    if (ky != max_Y_map)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                                    {
                                                        if (map[kx - 1, ky + 1] == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                break;
                                            }
                                        case 5:
                                            {
                                                if (itog_location_shablon == 2)
                                                {
                                                    if (ky > 0)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                                    {
                                                        if (map[kx + 1, ky - 1] == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                else if (itog_location_shablon == 3)
                                                {
                                                    if (kx > 0)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                                    {
                                                        if (map[kx - 1, ky + 1] == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                break;
                                            }
                                        case 6:
                                            {
                                                if (itog_location_shablon == 0)
                                                {
                                                    if (ky > 0)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                                    {
                                                        if (map[kx - 1, ky - 1] == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                else if (itog_location_shablon == 3)
                                                {
                                                    if (kx < max_X_map)//не ставится только если проверяемая клеткая находится на крае противоположному выходу поворотного шаблона
                                                    {
                                                        if (map[kx + 1, ky + 1] == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                break;
                                            }
                                        case 7:
                                            {
                                                if (itog_location_shablon == 0)///////////////////////////////////////////////////////////////////////////////////
                                                {
                                                    peremen_2 = 1;
                                                }
                                                else if (itog_location_shablon == 2)
                                                {
                                                    peremen_2 = 1;
                                                }
                                                else if (itog_location_shablon == 1)
                                                {
                                                    peremen_2 = 1;
                                                }
                                                break;
                                            }
                                        case 8:
                                            {
                                                if (itog_location_shablon == 0)///////////////////////////////////////////////////////////////////////////////////
                                                {
                                                    peremen_2 = 1;
                                                }
                                                else if (itog_location_shablon == 2)
                                                {
                                                    peremen_2 = 1;
                                                }
                                                else if (itog_location_shablon == 3)
                                                {
                                                    peremen_2 = 1;
                                                }
                                                break;
                                            }
                                        case 9:
                                            {
                                                if (itog_location_shablon == 1)///////////////////////////////////////////////////////////////////////////////////
                                                {
                                                    peremen_2 = 1;
                                                }
                                                else if (itog_location_shablon == 2)
                                                {
                                                    peremen_2 = 1;
                                                }
                                                else if (itog_location_shablon == 3)
                                                {
                                                    peremen_2 = 1;
                                                }
                                                break;
                                            }
                                        case 10:
                                            {
                                                if (itog_location_shablon == 0)///////////////////////////////////////////////////////////////////////////////////
                                                {
                                                    peremen_2 = 1;
                                                }
                                                else if (itog_location_shablon == 1)
                                                {
                                                    peremen_2 = 1;
                                                }
                                                else if (itog_location_shablon == 3)
                                                {
                                                    peremen_2 = 1;
                                                }
                                                break;
                                            }
                                    }
                                }
                                //
                                switch (itog_location_shablon)
                                {
                                    case 0:
                                        {
                                            map[kx - 1, ky] = itog_shablon;
                                            kx = kx - 1;
                                            break;
                                        }
                                    case 1:
                                        {
                                            map[kx, ky - 1] = itog_shablon;
                                            ky = ky - 1;
                                            break;
                                        }
                                    case 2:
                                        {
                                            map[kx + 1, ky] = itog_shablon;
                                            kx = kx + 1;
                                            break;
                                        }
                                    case 3:
                                        {
                                            map[kx, ky + 1] = itog_shablon;
                                            ky = ky + 1;
                                            break;
                                        }
                                }
                                //problems_problems_problems_problems_problems_problems_problems_problems_problems_//problems_problems_problems_problems_problems_problems_problems_problems_problems_
                                for (t = 0; t < map.GetLength(1); t++)
                                {
                                    for (f = 0; f < map.GetLength(0); f++)
                                    {
                                        Console.Write(map[f, t]);
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
    public enum Shablons
    {
        Перекрёсток = 11,
        Вертикаль = 1,
        Горизонталь = 2,
        Поворот_с_низа_налево = 3,
        Поворот_с_низа_направо = 4,
        Поворот_с_верха_налево = 5,
        Поворот_с_верха_направо = 6,
        Т_основа_низ = 7,
        Т_основа_верх = 8,
        Т_основа_лево = 9,
        Т_основа_право = 10,
    }
}

internal class Metods
{
    public void Char_map(int[,] arr)
    {
        char[,] char_map = new char[arr.GetLength(0) * 3, arr.GetLength(1) * 3];
        int sh_2;
        int X = 1;
        int Y = 1;
        int playerX;
        int playerY;
        for (int sh = 0; sh < arr.GetLength(1); sh++)
        {
            X = 1;
            for (sh_2 = 0; sh_2 < arr.GetLength(0); sh_2++)
            {
                switch (arr[sh, sh_2])
                {
                    case 1:
                        {
                            char_map[X, Y] = '▒';

                            char_map[X, Y + 1] = '█';
                            char_map[X, Y - 1] = '█';
                            char_map[X + 1, Y] = '▒';
                            char_map[X - 1, Y] = '▒';

                            char_map[X + 1, Y + 1] = '█';
                            char_map[X - 1, Y + 1] = '█';
                            char_map[X + 1, Y - 1] = '█';
                            char_map[X - 1, Y - 1] = '█';
                            break;
                        }
                    case 2:
                        {
                            char_map[X, Y] = '▒';
                            char_map[X, Y + 1] = '▒';
                            char_map[X, Y - 1] = '▒';
                            char_map[X + 1, Y] = '█';
                            char_map[X - 1, Y] = '█';
                            char_map[X + 1, Y + 1] = '█';
                            char_map[X - 1, Y + 1] = '█';
                            char_map[X + 1, Y - 1] = '█';
                            char_map[X - 1, Y - 1] = '█';
                            break;
                        }
                    case 3:
                        {
                            char_map[X, Y] = '▒';

                            char_map[X, Y + 1] = '█';
                            char_map[X, Y - 1] = '▒';
                            char_map[X + 1, Y] = '▒';
                            char_map[X - 1, Y] = '█';

                            char_map[X + 1, Y + 1] = '█';
                            char_map[X - 1, Y + 1] = '█';
                            char_map[X + 1, Y - 1] = '█';
                            char_map[X - 1, Y - 1] = '█';
                            break;
                        }
                    case 4:
                        {
                            char_map[X, Y] = '▒';
                            char_map[X, Y + 1] = '▒';
                            char_map[X, Y - 1] = '█';
                            char_map[X + 1, Y] = '▒';
                            char_map[X - 1, Y] = '█';

                            char_map[X + 1, Y + 1] = '█';
                            char_map[X - 1, Y + 1] = '█';
                            char_map[X + 1, Y - 1] = '█';
                            char_map[X - 1, Y - 1] = '█';
                            break;
                        }
                    case 5:
                        {
                            char_map[X, Y] = '▒';
                            char_map[X, Y + 1] = '█';
                            char_map[X, Y - 1] = '▒';
                            char_map[X + 1, Y] = '█';
                            char_map[X - 1, Y] = '▒';

                            char_map[X + 1, Y + 1] = '█';
                            char_map[X - 1, Y + 1] = '█';
                            char_map[X + 1, Y - 1] = '█';
                            char_map[X - 1, Y - 1] = '█';
                            break;
                        }
                    case 6:
                        {
                            char_map[X, Y] = '▒';
                            char_map[X, Y + 1] = '▒';
                            char_map[X, Y - 1] = '█';
                            char_map[X + 1, Y] = '█';
                            char_map[X - 1, Y] = '▒';

                            char_map[X + 1, Y + 1] = '█';
                            char_map[X - 1, Y + 1] = '█';
                            char_map[X + 1, Y - 1] = '█';
                            char_map[X - 1, Y - 1] = '█';
                            break;
                        }
                    case 7:
                        {
                            char_map[X, Y] = '▒';

                            char_map[X, Y + 1] = '▒';
                            char_map[X, Y - 1] = '▒';
                            char_map[X + 1, Y] = '▒';
                            char_map[X - 1, Y] = '█';

                            char_map[X + 1, Y + 1] = '█';
                            char_map[X - 1, Y + 1] = '█';
                            char_map[X + 1, Y - 1] = '█';
                            char_map[X - 1, Y - 1] = '█';
                            break;
                        }
                    case 8:
                        {
                            char_map[X, Y] = '▒';

                            char_map[X, Y + 1] = '▒';
                            char_map[X, Y - 1] = '▒';
                            char_map[X + 1, Y] = '█';
                            char_map[X - 1, Y] = '▒';

                            char_map[X + 1, Y + 1] = '█';
                            char_map[X - 1, Y + 1] = '█';
                            char_map[X + 1, Y - 1] = '█';
                            char_map[X - 1, Y - 1] = '█';
                            break;
                        }
                    case 9:
                        {
                            char_map[X, Y] = '▒';

                            char_map[X, Y + 1] = '█';
                            char_map[X, Y - 1] = '▒';
                            char_map[X + 1, Y] = '▒';
                            char_map[X - 1, Y] = '▒';

                            char_map[X + 1, Y + 1] = '█';
                            char_map[X - 1, Y + 1] = '█';
                            char_map[X + 1, Y - 1] = '█';
                            char_map[X - 1, Y - 1] = '█';
                            break;
                        }
                    case 10:
                        {
                            char_map[X, Y] = '▒';

                            char_map[X, Y + 1] = '▒';
                            char_map[X, Y - 1] = '█';
                            char_map[X + 1, Y] = '▒';
                            char_map[X - 1, Y] = '▒';

                            char_map[X + 1, Y + 1] = '█';
                            char_map[X - 1, Y + 1] = '█';
                            char_map[X + 1, Y - 1] = '█';
                            char_map[X - 1, Y - 1] = '█';
                            break;
                        }
                    case 11:
                        {
                            char_map[X, Y] = '▒';

                            char_map[X, Y + 1] = '▒';
                            char_map[X, Y - 1] = '▒';
                            char_map[X + 1, Y] = '▒';
                            char_map[X - 1, Y] = '▒';

                            char_map[X + 1, Y + 1] = '█';
                            char_map[X - 1, Y + 1] = '█';
                            char_map[X + 1, Y - 1] = '█';
                            char_map[X - 1, Y - 1] = '█';
                            break;
                        }
                    default:
                        {
                            char_map[X, Y] = '▒';

                            char_map[X, Y + 1] = '▒';
                            char_map[X, Y - 1] = '▒';
                            char_map[X + 1, Y] = '▒';
                            char_map[X - 1, Y] = '▒';

                            char_map[X + 1, Y + 1] = '▒';
                            char_map[X - 1, Y + 1] = '▒';
                            char_map[X + 1, Y - 1] = '▒';
                            char_map[X - 1, Y - 1] = '▒';
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
