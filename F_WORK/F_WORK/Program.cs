
using System;
namespace F_WORK
{
    class Programm
    {
        static void Main(string[] args)
        {
            int kx, ky;
            int[] prod_map;
            char[,] char_map;
            int max_X_map = 0;
            int max_Y_map = 0;
            Random random = new Random();
            Metods metods = new Metods();
            int itog_location_shablon;
            int itog_shablon = 0;
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
            if (map[kx, ky] == 2 || map[kx, ky] == 6 || map[kx, ky] == 8 || map[kx, ky] == 5 || map[kx, ky] == 2)
            {
                map[kx, ky] = 1;
            }
            int peremen_2;
            int peremen_3 = 0;
            int peremen_4;
            int sh;
            int smena;
            int smena_2;
            int game = 0;
            int game_peremen;
            int victory = 0;
            double speed = 0;
            ConsoleKeyInfo Button = Console.ReadKey();
            while (peremen_3 != 1)
            {
                prod_map = metods.Check_mashine(kx, ky, map);
                Console.Write(prod_map[0]);
                Console.Write(prod_map[1]);
                Console.Write(prod_map[2]);
                Console.WriteLine(prod_map[3]);
                itog_location_shablon = metods.Metod_itog_location_shablon(prod_map,kx,ky,map);
                if(itog_location_shablon ==10)
                {
                    if (prod_map[0] == 0 && prod_map[1] == 0 && prod_map[2] == 0 && prod_map[3] == 0)
                    {                       
                        for (smena = 0; smena < map.GetLength(1); smena++)
                        {
                            for (smena_2 = 0; smena_2 < map.GetLength(0); smena_2++)
                            {
                                Console.WriteLine("eop");
                                if (map[smena_2, smena] != 0)
                                {
                                    kx = smena_2;
                                    ky = smena;
                                    Console.WriteLine("X - " + kx);
                                    Console.WriteLine("Y - " + ky);
                                    prod_map = metods.Check_mashine(kx, ky, map);
                                    if (prod_map[0] != 0 || prod_map[1] != 0 || prod_map[2] != 0 || prod_map[3] != 0)
                                    {
                                        smena_2 = map.GetLength(0);
                                        smena = map.GetLength(1);
                                    }
                                }
                            }
                        }
                    }
                }
                itog_shablon = metods.Generat_mashine_part_2(prod_map,itog_location_shablon,kx,ky,map);
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
                for (sh = 0; sh <= max_X_map; sh++)
                {
                    if (map[sh, 0] == 11 || map[sh, 0] == 6 || map[sh, 0] == 5 || map[sh, 0] == 8 || map[sh, 0] == 9 || map[sh, 0] == 10 || map[sh, 0] == 1)
                    {
                        peremen_3 = 1;
                    }
                }
            }
            char_map = metods.Char_map(map);
            for (int shsh = 0; shsh < char_map.GetLength(0); shsh++)
            {
                for (int shs = 0; shs < char_map.GetLength(1); shs++)
                {
                    Console.Write(char_map[shsh, shs]);
                }
                Console.WriteLine();
            }
            for (int t = 0; t < map.GetLength(1); t++)
            {
                for (int f = 0; f < map.GetLength(0); f++)
                {
                    Console.WriteLine("t - " + t);
                    Console.WriteLine("f - " + f);
                    kx = f;
                    ky = t;
                    peremen_4 = 0;
                    if (map[f, t] != 0)//
                    {
                        Console.WriteLine("Переменная - " + f + " , " + t + " занята");
                        while (peremen_4 != 1)
                        {
                            prod_map = metods.Check_mashine(kx, ky, map);
                            if (prod_map[0] == 0 && prod_map[1] == 0 && prod_map[2] == 0 && prod_map[3] == 0)
                            {
                                peremen_4 = 1;
                            }
                            else
                            {
                                itog_location_shablon = metods.Metod_itog_location_shablon(prod_map, kx, ky, map);
                                peremen_2 = 0;
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
                                                    if (kx > 0)
                                                    {
                                                        if (map[kx - 1, ky - 1] == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                if (itog_location_shablon == 2)
                                                {
                                                    if (ky != max_Y_map)
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
                                                    if (kx < max_X_map)
                                                    {
                                                        if (map[kx + 1, ky - 1] == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                if (itog_location_shablon == 0)
                                                {
                                                    if (ky != max_Y_map)
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
                                                    if (ky > 0)
                                                    {
                                                        if (map[kx + 1, ky - 1] == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                else if (itog_location_shablon == 3)
                                                {
                                                    if (kx > 0)
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
                                                    if (ky > 0)
                                                    {
                                                        if (map[kx - 1, ky - 1] == 0)
                                                        {
                                                            peremen_2 = 1;
                                                        }
                                                    }
                                                }
                                                else if (itog_location_shablon == 3)
                                                {
                                                    if (kx < max_X_map)
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
                                                if (itog_location_shablon == 0)
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
                                                if (itog_location_shablon == 0)
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
                                                if (itog_location_shablon == 1)
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
                                                if (itog_location_shablon == 0)
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
                            }
                        }
                    }
                }
            }
            char_map = metods.Char_map(map);
            for (int shsh = 0; shsh < char_map.GetLength(0); shsh++)
            {
                for (int shs = 0; shs < char_map.GetLength(1); shs++)
                {
                    Console.Write(char_map[shsh, shs]);
                }
                Console.WriteLine();
            }
            for (int shsh = 0; shsh < char_map.GetLength(0); shsh++)
            {
                for (int shs = 0; shs < char_map.GetLength(1); shs++)
                {
                    if (shsh == 0 || shsh == char_map.GetLength(0) - 1 || shs == 0 || shs == char_map.GetLength(1) - 1)
                    { 
                        if (char_map[shsh, shs] == '▒')
                        {
                            char_map[shsh, shs] = '█';
                        }
                    }
                }
            }
            for (int shsh = 0; shsh < char_map.GetLength(0); shsh++)
            {
                for (int shs = 0; shs < char_map.GetLength(1); shs++)
                {
                        if (char_map[shsh, shs] == 'P')
                        {
                            char_map[shsh-1, shs] = 'P';
                            char_map[shsh, shs] = '█';
                        }
                }
            }
            for (int shsh = 0; shsh < char_map.GetLength(0); shsh++)
            {
                for (int shs = 0; shs < char_map.GetLength(1); shs++)
                {
                    Console.Write(char_map[shsh, shs]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            for (int shsh = 0; shsh < char_map.GetLength(1); shsh++)
            {
                for (int shs = 0; shs < char_map.GetLength(0); shs++)
                {
                    if (char_map[shs, shsh] == 'P')
                    {
                        kx = shs;
                        ky = shsh;
                    }
                }
            }
            while (game !=1)
            {
                Console.Clear();
                if (kx - 1<0||ky-2 <0)
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx - 1, ky - 2]);
                }
                if (kx - 1 < 0 || ky - 1 < 0)
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx - 1, ky - 1]);
                }
                if (kx - 1 < 0)
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx-1, ky]);
                }
                if (ky + 1 >= char_map.GetLength(1)|| kx - 1 < 0)
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx - 1 , ky + 1]);
                }
                if (ky + 2 >= char_map.GetLength(1) || kx - 1 < 0)
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx - 1, ky + 2]);
                }
                Console.WriteLine();
                if (ky - 2 < 0)
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx, ky-2]);
                }
                if (ky - 1 < 0 )
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx, ky-1]);
                }            
                Console.Write(char_map[kx, ky]);
                if (ky+ 1 >= char_map.GetLength(1))
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx, ky+1]);
                }
                if (ky + 2 >= char_map.GetLength(1))
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx, ky+2]);
                }
                Console.WriteLine();
                if (ky - 2 < 0 || kx + 1 >= char_map.GetLength(0))
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx +1, ky - 2]);
                }
                if (ky - 1 < 0 || kx + 1 >= char_map.GetLength(0))
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx +1, ky - 1]);
                }
                if (kx+ 1 >= char_map.GetLength(0))
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx+1, ky]);
                }
                if (ky+ 1 >= char_map.GetLength(1) || kx + 1 >= char_map.GetLength(0))
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx + 1, ky + 1]);
                }
                if (ky + 2 >= char_map.GetLength(1) || kx + 1 >= char_map.GetLength(0))
                {
                    Console.Write('X');
                }
                else
                {
                    Console.Write(char_map[kx + 1, ky + 2]);
                }
                Console.WriteLine();
                game_peremen = 0;
                while(game_peremen!=1)
                {
                   Button = Console.ReadKey();
                   if(Button.KeyChar == 'w')
                   {
                        if(char_map[kx-1,ky]== '▒')
                        {
                            game_peremen = 1;
                        }
                        else if (char_map[kx-1, ky] == 'U')
                        {
                            game_peremen = 1;
                            victory = 1;
                        }
                   }
                    else if (Button.KeyChar == 'a')
                    {
                        if (char_map[kx, ky-1] == '▒')
                        {
                            game_peremen = 1;
                        }
                    }
                    else if (Button.KeyChar == 's')
                    {
                        if (char_map[kx+1, ky] == '▒')
                        {
                            game_peremen = 1;
                        }
                    }
                    else if (Button.KeyChar == 'd')
                    {
                        if (char_map[kx, ky+1] == '▒')
                        {
                            game_peremen = 1;
                        }
                    }
                }
                if (victory == 1)
                {
                    game = 1;
                    continue;
                }
                if (Button.KeyChar == 'w')
                {
                    char_map[kx, ky] = '▒';
                    char_map[kx-1, ky] = 'P';
                    kx = kx-1;
                    ky = ky;
                }
                if (Button.KeyChar == 'a')
                {
                    char_map[kx, ky] = '▒';
                    char_map[kx, ky-1] = 'P';
                    kx = kx;
                    ky = ky-1;
                }
                if (Button.KeyChar == 's')
                {
                    char_map[kx, ky] = '▒';
                    char_map[kx+1, ky ] = 'P';
                    kx = kx+1;
                    ky = ky;
                }
                if (Button.KeyChar == 'd')
                {
                    char_map[kx, ky] = '▒';
                    char_map[kx, ky+1] = 'P';
                    kx = kx;
                    ky = ky+1;
                }
                speed++;
            }
            Console.WriteLine("ХАРОШ, ты сделал " +speed + " шагов." );
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
    /// <summary>
    /// Возвращает ваш лаберинт в виде символов
    /// </summary>
    /// <param name="arr">двумерный массив типа int</param>
    /// <returns>двумерный массив типа char</returns>
    public Char[,] Char_map(int[,] arr)
    {
        char[,] char_map = new char[arr.GetLength(1) * 3, arr.GetLength(0) * 3];
        int sh_2;
        int X = 1;
        int Y = 1;
        int peremen = 0;
        int ds = 0;
        Random random = new Random();
        for (int sh = 0; sh < arr.GetLength(0); sh++)
        {
            X = 1;
            for (sh_2 = 0; sh_2 < arr.GetLength(1); sh_2++)
            {
                switch (arr[sh, sh_2])
                {
                    case 0:
                        {
                            char_map[X, Y] = '█';

                            char_map[X, Y + 1] = '█';
                            char_map[X, Y - 1] = '█';
                            char_map[X + 1, Y] = '█';
                            char_map[X - 1, Y] = '█';

                            char_map[X + 1, Y + 1] = '█';
                            char_map[X - 1, Y + 1] = '█';
                            char_map[X + 1, Y - 1] = '█';
                            char_map[X - 1, Y - 1] = '█';
                            break;
                        }
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
            
        return char_map;
    }
    /// <summary>
    /// Проверяет свободные места вокруг проверяемого шаблона в массиве
    /// </summary>
    /// <param name="kx">координата проверяемого шаблона X</param>
    /// <param name="ky">координата проверяемого шаблона Y</param>
    /// <param name="map">двумерный массив типа int, в которой будет будет проводится проверка</param>
    /// <returns>одномерный массив типа int, который используется для обозначения свободных мест</returns>
    public int[] Check_mashine(int kx, int ky, int[,] map)
    {
        //получение информации окружения взависимости от положения проверяемой клетки
        //углы
        int[] prod_map = new int[4];
        int max_X_map = map.GetLength(0);
        int max_Y_map = map.GetLength(1);
        max_X_map = max_X_map - 1;
        max_Y_map = max_Y_map - 1;
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
        return prod_map;
    }
    /// <summary>
    /// Решает куда ставить следующий шаблон
    /// </summary>
    /// <param name="prod_map">информация о окружающих клетках(prod_map)</param>
    /// <param name="kx">координата проверяемого шаблона X</param>
    /// <param name="ky">координата проверяемого шаблона Y</param>
    /// <param name="map">двумерный массив типа int</param>
    /// <returns>Значение определяющая куда поставится следующий шаблон</returns>
    public int Metod_itog_location_shablon(int[]prod_map, int kx, int ky, int[,] map)
    {
       int peremen = 0;
       int itog_location_shablon=0;
       Random random = new Random();
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
            if (prod_map[0] == 0 && prod_map[1] == 0 && prod_map[2] == 0 && prod_map[3] == 0)
            {            
              peremen = 1;
              itog_location_shablon = 10;
            }
        }
        return itog_location_shablon;
    }
    /// <summary>
    /// Решает какой шаблон ставить
    /// </summary>
    /// <param name="prod_map">информация о окружающих клетках(prod_map)</param>
    /// <param name="itog_location_shablon">значение определяющая куда поставится следующий шаблон</param>
    /// <param name="kx">координата проверяемого шаблона X</param>
    /// <param name="ky">координата проверяемого шаблона Y</param>
    /// <param name="map">двумерный массив типа int</param>
    /// <returns>Значение определяющая какой шаблон ставить</returns>
    public int Generat_mashine_part_2(int[]prod_map,int itog_location_shablon, int kx, int ky, int[,] map)
    {
        int peremen_2 = 0;
        int itog_shablon=0;
        Random random = new Random();
        int max_X_map = map.GetLength(0);
        int max_Y_map = map.GetLength(1);
        max_X_map = max_X_map - 1;
        max_Y_map = max_Y_map - 1;
        while (peremen_2 != 1)
        {
            if (prod_map[0] == 0 && prod_map[1] == 0 && prod_map[2] == 0 && prod_map[3] == 0)
            {
                peremen_2 = 1;
                continue;
            }
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
                    peremen_2 = 1;
                }
            }
            if (itog_location_shablon == 3)
            {
                if (ky + 1 != max_Y_map)
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
                if (kx != 1)
                {
                    peremen_2 = 1;
                }
            }
            if (itog_location_shablon == 2)
            {
                if (kx + 1 != max_X_map)
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
                if (kx > 0)
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
                if (kx < max_X_map)
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
                if (ky > 0)
                {
                    if (map[kx + 1, ky - 1] == 0)
                    {
                        peremen_2 = 1;
                    }
                }
            }
            else if (itog_location_shablon == 3)
            {
                if (kx > 0)
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
                if (ky > 0)
                {
                    if (map[kx - 1, ky - 1] == 0)
                    {
                        peremen_2 = 1;
                    }
                }
            }
            else if (itog_location_shablon == 3)
            {
                if (kx < max_X_map)
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
            if (itog_location_shablon == 0)
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
            if (itog_location_shablon == 3)
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
            if (itog_location_shablon == 3)
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
        return itog_shablon;
    }
}