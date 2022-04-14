using System;
namespace F_WORK
{
    class Programm
    {
        static void Main(string[] args)
        {
            /*
           ConsoleKeyInfo KAKA;
           for(int ror =0; ror !=20;ror++)
           {
               KAKA = Console.ReadKey();
               Console.WriteLine(KAKA.KeyChar);
           }
           */
            int kx = 1, ky = 1;
            int[,] map = new int[3, 3];
            int[] prod_map = new int[4];
            Random random = new Random();
            int itog_location_shablon = 0;
            int itog_shablon = 0;
            int peremen = 0;
            int peremen_2 = 0;
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
            else if (kx == 2 && ky == 2)//левый нижний угол
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
            else if (kx == 2 && ky == 0)//левый верхний угол
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
            else if (kx == 0 && ky == 2)//правый нижний угол
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
            // края
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
            else if (kx == 2)//лево
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
            else if (ky == 2)//низ
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
            else if (kx == 1 && ky == 1)
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
            }
            //генерация максимально подходящего шаблона
            //ёбаный английский язык блять нахуй сукадолбаёб
            { 
            //для генерации нужно:1 - естественно рандомизер
            //                    2 - условия(какие шаблоны(в пользу направления пути) воопше разрешены в тех или иных координатах окружения)
            //                    3 - +БОНУС - зделать проверятор тупикоB, алгоритм должен делать неповторяемые последовательности шагов по лаберинту начиная с выхода свеже-(типо)поставленого шаблона и если за примерно 200 попыток не доходит до выхода то генерируется другой шаблон
             }
            while(peremen_2 !=1)
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
                            if(itog_location_shablon == 1 || itog_location_shablon == 3)
                            {
                                peremen_2 = 1;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (itog_location_shablon == 0 || itog_location_shablon == 2)
                            {
                                peremen_2 = 1;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (itog_location_shablon == 1)
                            {
                                peremen_2 = 1;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (itog_location_shablon == 1)
                            {
                                peremen_2 = 1;
                            }
                            break;
                        }
                    case 5:
                        {
                            if (itog_location_shablon == 2 || itog_location_shablon == 3)
                            {
                                peremen_2 = 1;
                            }
                            break;
                        }
                    case 6:
                        {
                            if (itog_location_shablon == 0 || itog_location_shablon == 3)
                            {
                                peremen_2 = 1;
                            }
                            break;
                        }
                    case 7:
                        {
                            if ( itog_location_shablon == 1)
                            {
                                peremen_2 = 1;
                            }
                            break;
                        }
                    case 8:
                        {
                            if (itog_location_shablon == 0 || itog_location_shablon == 2 || itog_location_shablon == 3)
                            {
                                peremen_2 = 1;
                            }
                            break;
                        }
                    case 9:
                        {
                            if (itog_location_shablon == 2 || itog_location_shablon == 1 || itog_location_shablon == 3)
                            {
                                peremen_2 = 1;
                            }
                            break;
                        }
                    case 10:
                        {
                            if (itog_location_shablon == 0 || itog_location_shablon == 1 || itog_location_shablon == 3)
                            {
                                peremen_2 = 1;
                            }
                            break;
                        }
                }
            }
            //засунуть число в карту
            // зделать условие которое передвигает координаты проверяемой клетки взависимости от иотогового положения сежегоо шаблона и потом зациклить


        }
    }
        public enum Shablons
        {
            Перекрёсток=11,
            Вертикаль=1,
            Горизонталь=2,
            Поворот_с_низа_налево=3,
            Поворот_с_низа_направо=4,
            Поворот_с_верха_налево=5,
            Поворот_с_верха_направо=6,
            Т_основа_низ=7,
            Т_основа_верх=8,
            Т_основа_лево=9,
            Т_основа_право=10,
            Тупик_левый=11,
            Тупик_правый=12,
            Тупик_верхний=13,
            Тупик_нижний=14

        }
       
    }

