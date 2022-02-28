using System;
using PRACTICA_WORK_IGRA;

/*
рпг с предметами без карты но с рандомно генерируемым окружением
3 локации, на последнем очень сильный враг
хп.наносимый урон.защита от получаемого уронаю. получаемый урон(определённого врага).золото
способностей 3.возможных способностей 8
вид сверху(создать массив как в крестиках и ноликах но посередине всегда игрок 
а остальные ячейки его рандомное оркужение полсе его хода,
угловые ячейки отсутствуют
предмет можно носить лишь один Всего предметов будет пять
окружение состоит из сундука с предметом(G), из мага со скиллами(Convert.ToChar(1)) ,из пустого пространства,из лекаря,и обманщика(своего рода казино)
враг активизируется полсе каждых 2ух ходов. для прохождения в следующую локацию нужно победить 2 врагов
 */

//ИГРОК
char t = ' ';
 t = Convert.ToChar(1);
Console.WriteLine(t);
t = Convert.ToChar(2);
Console.WriteLine(t);
t = Convert.ToChar(3);
Console.WriteLine(t);
t = Convert.ToChar(4);
Console.WriteLine(t);
t = Convert.ToChar(5);
Console.WriteLine(t);


char[] visual = new char[] { 'X','X', 'O', 'X','X'}; //чисто визуальная часть игры

int[] systematic = new int[] { 0, 0, 0, 0, 0 };
Random OKRUZH = new Random();
systematic[0] = OKRUZH.Next(0, 5);
systematic[1] = OKRUZH.Next(0, 4);
systematic[3] = OKRUZH.Next(0, 4);
systematic[4] = OKRUZH.Next(0, 4);


//оформление карты//оформление карты//оформление карты//оформление карты//оформление карты//оформление карты//оформление карты//оформление карты//оформление карты//оформление карты
if (systematic[0] == 0 || systematic[0] == 5)
{
    visual[0] = 'X';//пустое пространство
}
else if(systematic[0] == 1)
{
    visual[0] = 'G';// сундук
}
else if (systematic[0] == 2)
{
    visual[0] = Convert.ToChar(2); //магаз мага
}
else if (systematic[0] == 3)
{
    visual[0] = '+';// лекарь
}
else if (systematic[0] == 4)
{
    visual[0] = Convert.ToChar(1);//обманщик
}

if (systematic[1] == 0 || systematic[1] == 5)
{ 
    visual[1] = 'X';
}
else if (systematic[1] == 1)
{
    visual[1] = 'G';
}
else if (systematic[1] == 2)
{
    visual[1] = Convert.ToChar(2); 
}
else if (systematic[1] == 3)
{
    visual[1] = '+';
}
else if (systematic[1] == 4)
{
    visual[1] = Convert.ToChar(1);
}

if (systematic[3] == 0 || systematic[3] == 5)
{
    visual[3] = 'X';
}
else if (systematic[3] == 1)
{
    visual[3] = 'G';
}
else if (systematic[3] == 2)
{
    visual[3] = Convert.ToChar(2);
}
else if (systematic[3] == 3)
{
    visual[3] = '+';
}
else if (systematic[3] == 4)
{
    visual[3] = Convert.ToChar(1);
}

if (systematic[4] == 0 || systematic[4] == 5)
{
    visual[4] = 'X';
}
else if (systematic[4] == 1)
{
    visual[4] = 'G';
}
else if (systematic[4] == 2)
{
    visual[4] = Convert.ToChar(2);
}
else if (systematic[4] == 3)
{
    visual[4] = '+';
}
else if (systematic[4] == 4)
{
    visual[4] = Convert.ToChar(1);
}

//создание переменных//создание переменных//создание переменных//создание переменных//создание переменных//создание переменных

Int32 Rucoiatca = new Int32();
Rucoiatca = 2;

int[] inventor = new int[] {0,0,0,0,0};
int[] inventor_skills = new int[] { 0, 0, 0, 0, 0, 0, 0 }; //значение значит доступ к методам класса SKILLS типо

Int32 GOLD = new Int32();
GOLD = 15;

int[] Slots_Skills_zaniatost = new int[] { 0, 0, 0 };
int[] Slots_Skills = new int[]{0,0,0};//слоты для скиллов
int SlotITEM = 0; //слот для предмета

Int32 REGEN_player = new Int32();
REGEN_player = 0; //регенерация жизни у игрока каждый ход

Int32 HP_player = new Int32(); //жизнь
HP_player = 32;

Int32 DAMAGE_player = new Int32(); // наносимый урон
DAMAGE_player = 2;

Int32 DEF_player = new Int32(); // защита от урона
DEF_player = 0;

Slots_Skills[0] = 1;
Slots_Skills_zaniatost[0] = 1;

Console.WriteLine("   [" + visual[0] + "]  ");
Console.WriteLine("[" + visual[1] + "][" + visual[2] + "][" + visual[3] + "]"); //карта
Console.WriteLine("   [" + visual[4] + "]  ");

Char VIBOR = new Char();
int RICHAG = 0;

Int32 Item_maga1 = new Int32(); //перед циклом определяется то что будет продавать маг что бы предметы нельзя было рандомить в игре
Item_maga1 = 0;
                                // продаёт он 1 скилл за ход
Random random = new Random();
Item_maga1 = random.Next(2,7);

while (RICHAG != 1)
{
    Console.WriteLine("q (инвентарь) ");
    Console.WriteLine("w,a,s,d");
    Char.TryParse(Console.ReadLine(), out VIBOR);
    Console.WriteLine(VIBOR);

    if (VIBOR == 'w')
    {
        if (systematic[0] == 0 || systematic[0] == 5)
        {
            Console.WriteLine("ничего нет");
        }
        else if(systematic[0] == 1)
        {
            Console.WriteLine("это сундук");
            Console.WriteLine("возьмёте предмет?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        Random SUNDa = new Random(); //тут игрок получает предмет и ход завершается
                        if (inventor[0] == 0)
                        {
                            inventor[0] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[0] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[0] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[0] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[0] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[0] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[0] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[1] == 0)
                        {
                            inventor[1] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[1] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[1] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[1] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[1] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[1] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[1] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[2] == 0)
                        {
                            inventor[2] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[2] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[2] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[2] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[2] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[2] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[2] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[3] == 0)
                        {
                            inventor[3] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[3] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[3] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[3] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[3] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[3] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[3] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[4] == 0)
                        {
                            inventor[4] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[4] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[4] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[4] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[4] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[4] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[4] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        RICHAG = 1;
                        systematic[0] = 0;
                        break;
                    }
            }
        }
        else if(systematic[0] == 2)
        {
            Console.WriteLine(" Это маг-торговец");
            Console.WriteLine(" Он продаёт знания которые могут помоч тебе в бою");
            Console.Write("Сейчас он продаёт ");
            string maaa;
            if (Item_maga1 == 2)
            {
                maaa = "Поцелуй";
                Console.WriteLine(maaa + ", стоит 15 монет");
            } 
            else if (Item_maga1 == 3)
            {
                maaa = "Лютую пятку";
                Console.WriteLine(maaa + ", стоит 75 монет");
            }
            else if (Item_maga1 == 4)
            {
                maaa = "Яд";
                Console.WriteLine(maaa + ", стоит 31 монету");
            }
            else if (Item_maga1 == 5)
            {
                maaa = "Молитву";
                Console.WriteLine(maaa + ", стоит 40 монет");
            }
            else if (Item_maga1 == 6)
            {
                maaa = "Подножку";
                Console.WriteLine(maaa + ", стоит 35 монет");
            }
            Console.WriteLine("у вас " + GOLD + " монет");
            Console.WriteLine("брать будете?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        if (Item_maga1 ==2)
                        {
                            if (GOLD < 15)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Поцелуй");
                                GOLD = GOLD - 15;
                                inventor_skills[0] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 3)
                        {
                            if (GOLD < 75)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Лютую пятку");
                                GOLD = GOLD - 75;
                                inventor_skills[1] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 4)
                        {
                            if (GOLD < 31)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Яд");
                                GOLD = GOLD - 31;
                                inventor_skills[2] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 5)
                        {
                            if (GOLD < 40)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Молитву");
                                GOLD = GOLD - 40;
                                inventor_skills[3] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 6)
                        {
                            if (GOLD < 35)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Подножку");
                                GOLD = GOLD - 35;
                                inventor_skills[4] = 1;
                                RICHAG = 1;
                            }
                        }
                        systematic[0] = 0;
                        break;
                    }
            }
        }
        else if (systematic[0] == 3)
        {
            Console.WriteLine("Это лекарь");
            Console.WriteLine("хотите восстановить здоровье?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        Console.WriteLine("лекарь восстановил вам здоровье");
                        HP_player = 32;
                        RICHAG = 1;
                        systematic[0] = 0;
                        break;
                    }
            }
        }
        else if (systematic[0] == 4)
        {
            Console.WriteLine("это странник, его нынче прозывают Обманщиком");
            Console.WriteLine("предлагает вам игру");
            Console.WriteLine("на столе шарик и если он не скатится со стола в течении 7 секунд - победа");
            Console.WriteLine("если скатиться - проигрышь ");
            Console.WriteLine("за победу получаете 10 монет");
            Console.WriteLine("за проигрышь теряете 10 монет");
            Console.WriteLine("играете?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        Random m = new Random();
                        int itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if(GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("1");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("2");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("3");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("4");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("5");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("6");
                            Console.ReadKey();
                        }
                        Console.WriteLine("7!!!");
                        Console.WriteLine("вы получили 10 монет");
                        GOLD = GOLD + 10;
                        RICHAG = 1;
                        systematic[0] = 0;
                        break;
                    }
            }
        }
    }
    else if (VIBOR == 'a')
    {
        if (systematic[1] == 0 || systematic[1] == 5)
        {
            Console.WriteLine("ничего нет");
        }
        else if (systematic[1] == 1)
        {
            Console.WriteLine("это сундук");
            Console.WriteLine("возьмёте предмет?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        Random SUNDa = new Random(); //тут игрок получает предмет и ход завершается
                        if (inventor[0] == 0)
                        {
                            inventor[0] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[0] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[0] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[0] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[0] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[0] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[0] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[1] == 0)
                        {
                            inventor[1] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[1] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[1] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[1] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[1] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[1] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[1] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[2] == 0)
                        {
                            inventor[2] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[2] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[2] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[2] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[2] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[2] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[2] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[3] == 0)
                        {
                            inventor[3] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[3] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[3] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[3] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[3] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[3] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[3] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[4] == 0)
                        {
                            inventor[4] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[4] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[4] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[4] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[4] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[4] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[4] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        RICHAG = 1;
                        systematic[1] = 0;
                        break;
                    }
            }
        }
        else if (systematic[1] == 2)
        {
            Console.WriteLine(" Это маг-торговец");
            Console.WriteLine(" Он продаёт знания которые могут помоч тебе в бою");
            Console.Write("Сейчас он продаёт ");
            string maaa;
            if (Item_maga1 == 2)
            {
                maaa = "Поцелуй";
                Console.WriteLine(maaa + ", стоит 15 монет");
            }
            else if (Item_maga1 == 3)
            {
                maaa = "Лютую пятку";
                Console.WriteLine(maaa + ", стоит 75 монет");
            }
            else if (Item_maga1 == 4)
            {
                maaa = "Яд";
                Console.WriteLine(maaa + ", стоит 31 монету");
            }
            else if (Item_maga1 == 5)
            {
                maaa = "Молитву";
                Console.WriteLine(maaa + ", стоит 40 монет");
            }
            else if (Item_maga1 == 6)
            {
                maaa = "Подножку";
                Console.WriteLine(maaa + ", стоит 35 монет");
            }
            Console.WriteLine("у вас " + GOLD + " монет");
            Console.WriteLine("брать будете?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        if (Item_maga1 == 2)
                        {
                            if (GOLD < 15)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Поцелуй");
                                GOLD = GOLD - 15;
                                inventor_skills[0] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 3)
                        {
                            if (GOLD < 75)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Лютую пятку");
                                GOLD = GOLD - 75;
                                inventor_skills[1] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 4)
                        {
                            if (GOLD < 31)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Яд");
                                GOLD = GOLD - 31;
                                inventor_skills[2] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 5)
                        {
                            if (GOLD < 40)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Молитву");
                                GOLD = GOLD - 40;
                                inventor_skills[3] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 6)
                        {
                            if (GOLD < 35)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Подножку");
                                GOLD = GOLD - 35;
                                inventor_skills[4] = 1;
                                RICHAG = 1;
                            }
                        }
                        systematic[1] = 0;
                        break;
                    }
            }
        }
        else if (systematic[1] == 3)
        {
            Console.WriteLine("Это лекарь");
            Console.WriteLine("хотите восстановить здоровье?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        Console.WriteLine("лекарь восстановил вам здоровье");
                        HP_player = 32;
                        systematic[1] = 0;
                        RICHAG = 1;
                        break;
                    }
            }
        }
        else if (systematic[1] == 4)
        {
            Console.WriteLine("это странник, его нынче прозывают Обманщиком");
            Console.WriteLine("предлагает вам игру");
            Console.WriteLine("на столе шарик и если он не скатится со стола в течении 7 секунд - победа");
            Console.WriteLine("если скатиться - проигрышь ");
            Console.WriteLine("за победу получаете 10 монет");
            Console.WriteLine("за проигрышь теряете 10 монет");
            Console.WriteLine("играете?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        Random m = new Random();
                        int itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("1");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("2");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("3");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("4");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("5");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("6");
                            Console.ReadKey();
                        }
                        Console.WriteLine("7!!!");
                        Console.WriteLine("вы получили 10 монет");
                        GOLD = GOLD + 10;
                        systematic[1] = 0;
                        RICHAG = 1;
                        break;
                    }
            }
        }
    }
    else if (VIBOR == 's')
    {
        if (systematic[4] == 0 || systematic[4] == 5)
        {
            Console.WriteLine("ничего нет");
        }
        else if (systematic[4] == 1)
        {
            Console.WriteLine("это сундук");
            Console.WriteLine("возьмёте предмет?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        Random SUNDa = new Random(); //тут игрок получает предмет и ход завершается
                        if (inventor[0] == 0)
                        {
                            inventor[0] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[0] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[0] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[0] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[0] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[0] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[0] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[1] == 0)
                        {
                            inventor[1] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[1] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[1] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[1] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[1] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[1] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[1] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[2] == 0)
                        {
                            inventor[2] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[2] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[2] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[2] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[2] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[2] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[2] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[3] == 0)
                        {
                            inventor[3] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[3] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[3] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[3] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[3] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[3] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[3] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[4] == 0)
                        {
                            inventor[4] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[4] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[4] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[4] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[4] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[4] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[4] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        systematic[4] = 0;
                        RICHAG = 1;
                        break;
                    }
            }
        }
        else if (systematic[4] == 2)
        {
            Console.WriteLine(" Это маг-торговец");
            Console.WriteLine(" Он продаёт знания которые могут помоч тебе в бою");
            Console.Write("Сейчас он продаёт ");
            string maaa;
            if (Item_maga1 == 2)
            {
                maaa = "Поцелуй";
                Console.WriteLine(maaa + ", стоит 15 монет");
            }
            else if (Item_maga1 == 3)
            {
                maaa = "Лютую пятку";
                Console.WriteLine(maaa + ", стоит 75 монет");
            }
            else if (Item_maga1 == 4)
            {
                maaa = "Яд";
                Console.WriteLine(maaa + ", стоит 31 монету");
            }
            else if (Item_maga1 == 5)
            {
                maaa = "Молитву";
                Console.WriteLine(maaa + ", стоит 40 монет");
            }
            else if (Item_maga1 == 6)
            {
                maaa = "Подножку";
                Console.WriteLine(maaa + ", стоит 35 монет");
            }
            Console.WriteLine("у вас " + GOLD + " монет");
            Console.WriteLine("брать будете?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        if (Item_maga1 == 2)
                        {
                            if (GOLD < 15)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Поцелуй");
                                GOLD = GOLD - 15;
                                inventor_skills[0] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 3)
                        {
                            if (GOLD < 75)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Лютую пятку");
                                GOLD = GOLD - 75;
                                inventor_skills[1] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 4)
                        {
                            if (GOLD < 31)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Яд");
                                GOLD = GOLD - 31;
                                inventor_skills[2] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 5)
                        {
                            if (GOLD < 40)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Молитву");
                                GOLD = GOLD - 40;
                                inventor_skills[3] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 6)
                        {
                            if (GOLD < 35)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Подножку");
                                GOLD = GOLD - 35;
                                inventor_skills[4] = 1;
                                RICHAG = 1;
                            }
                        }
                        systematic[4] = 0;
                        break;
                    }
            }
        }
        else if (systematic[4] == 3)
        {
            Console.WriteLine("Это лекарь");
            Console.WriteLine("хотите восстановить здоровье?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        Console.WriteLine("лекарь восстановил вам здоровье");
                        HP_player = 32;
                        systematic[4] = 0;
                        RICHAG = 1;
                        break;
                    }
            }
        }
        else if (systematic[4] == 4)
        {
            Console.WriteLine("это странник, его нынче прозывают Обманщиком");
            Console.WriteLine("предлагает вам игру");
            Console.WriteLine("на столе шарик и если он не скатится со стола в течении 7 секунд - победа");
            Console.WriteLine("если скатиться - проигрышь ");
            Console.WriteLine("за победу получаете 10 монет");
            Console.WriteLine("за проигрышь теряете 10 монет");
            Console.WriteLine("играете?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        Random m = new Random();
                        int itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("1");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("2");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("3");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("4");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("5");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("6");
                            Console.ReadKey();
                        }
                        Console.WriteLine("7!!!");
                        Console.WriteLine("вы получили 10 монет");
                        GOLD = GOLD + 10;
                        systematic[4] = 0;
                        RICHAG = 1;
                        break;
                    }
            }
        }
    }
    else if (VIBOR == 'd')
    {
        if (systematic[3] == 0 || systematic[3] == 5)
        {
            Console.WriteLine("ничего нет");
        }
        else if (systematic[3] == 1)
        {
            Console.WriteLine("это сундук");
            Console.WriteLine("возьмёте предмет?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        Random SUNDa = new Random(); //тут игрок получает предмет и ход завершается
                        if (inventor[0] == 0)
                        {
                            inventor[0] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[0] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[0] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[0] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[0] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[0] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[0] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[1] == 0)
                        {
                            inventor[1] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[1] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[1] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[1] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[1] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[1] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[1] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[2] == 0)
                        {
                            inventor[2] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[2] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[2] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[2] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[2] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[2] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[2] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[3] == 0)
                        {
                            inventor[3] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[3] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[3] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[3] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[3] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[3] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[3] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        else if (inventor[4] == 0)
                        {
                            inventor[4] = SUNDa.Next(0, 6);//рандомит предмет и занимает ячейку и туда больше рандомить не будет

                            if (inventor[4] == 1)//проверяет что вы получили и выводит на консоль
                            {
                                Console.WriteLine("вы получили ДОСПЕХИ");
                            }
                            else if (inventor[4] == 2)
                            {
                                Console.WriteLine("вы получили АМУЛЕТ");
                            }
                            else if (inventor[4] == 3)
                            {
                                Console.WriteLine("вы получили ЛЕАНУ");
                            }
                            else if (inventor[4] == 4)
                            {
                                Console.WriteLine("вы получили КОЛЬЦО КРОВОСИСИ");
                            }
                            else if (inventor[4] == 5)
                            {
                                Console.WriteLine("вы получили ИГРУШЕЧНУЮ СОБАКУ");
                            }
                            else if (inventor[4] == 0)
                            {
                                Console.WriteLine("вы ничего не получили ");
                            }
                        }
                        systematic[3] = 0;
                        RICHAG = 1;
                        break;
                    }
            }
        }
        else if (systematic[3] == 2)
        {
            Console.WriteLine(" Это маг-торговец");
            Console.WriteLine(" Он продаёт знания которые могут помоч тебе в бою");
            Console.Write("Сейчас он продаёт ");
            string maaa;
            if (Item_maga1 == 2)
            {
                maaa = "Поцелуй";
                Console.WriteLine(maaa + ", стоит 15 монет");
            }
            else if (Item_maga1 == 3)
            {
                maaa = "Лютую пятку";
                Console.WriteLine(maaa + ", стоит 75 монет");
            }
            else if (Item_maga1 == 4)
            {
                maaa = "Яд";
                Console.WriteLine(maaa + ", стоит 31 монету");
            }
            else if (Item_maga1 == 5)
            {
                maaa = "Молитву";
                Console.WriteLine(maaa + ", стоит 40 монет");
            }
            else if (Item_maga1 == 6)
            {
                maaa = "Подножку";
                Console.WriteLine(maaa + ", стоит 35 монет");
            }
            Console.WriteLine("у вас " + GOLD + " монет");
            Console.WriteLine("брать будете?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        if (Item_maga1 == 2)
                        {
                            if (GOLD < 15)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Поцелуй");
                                GOLD = GOLD - 15;
                                inventor_skills[0] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 3)
                        {
                            if (GOLD < 75)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Лютую пятку");
                                GOLD = GOLD - 75;
                                inventor_skills[1] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 4)
                        {
                            if (GOLD < 31)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Яд");
                                GOLD = GOLD - 31;
                                inventor_skills[2] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 5)
                        {
                            if (GOLD < 40)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Молитву");
                                GOLD = GOLD - 40;
                                inventor_skills[3] = 1;
                                RICHAG = 1;
                            }
                        }
                        else if (Item_maga1 == 6)
                        {
                            if (GOLD < 35)
                            {
                                Console.WriteLine("монет не хватает");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("хорошо");
                                Console.WriteLine("вы получили Подножку");
                                GOLD = GOLD - 35;
                                inventor_skills[4] = 1;
                                RICHAG = 1;
                            }
                        }
                        systematic[3] = 0;
                        break;
                    }
            }
        }
        else if (systematic[3] == 3)
        {
            Console.WriteLine("Это лекарь");
            Console.WriteLine("хотите восстановить здоровье?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        Console.WriteLine("лекарь восстановил вам здоровье");
                        HP_player = 32;
                        systematic[3] = 0;
                        RICHAG = 1;
                        break;
                    }
            }
        }
        else if (systematic[3] == 4)
        {
            Console.WriteLine("это странник, его нынче прозывают Обманщиком");
            Console.WriteLine("предлагает вам игру");
            Console.WriteLine("на столе шарик и если он не скатится со стола в течении 7 секунд - победа");
            Console.WriteLine("если скатиться - проигрышь ");
            Console.WriteLine("за победу получаете 10 монет");
            Console.WriteLine("за проигрышь теряете 10 монет");
            Console.WriteLine("играете?");
            Console.WriteLine("no, yes");
            string VIBOR_POTVERZHDENIA = Console.ReadLine();
            switch (VIBOR_POTVERZHDENIA)
            {
                case ("no"):
                    {
                        continue;
                    }
                case ("yes"):
                    {
                        Random m = new Random();
                        int itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("1");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("2");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("3");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("4");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("5");
                            Console.ReadKey();
                        }
                        itog = m.Next(1, 10);
                        if (itog == 1)
                        {
                            Console.WriteLine("шарик скатился, вы лешились 10 монет");
                            if (GOLD <= 10)
                            {
                                GOLD = GOLD - GOLD;
                            }
                            else
                            {
                                GOLD = GOLD - 10;
                            }
                            RICHAG = 1;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("6");
                            Console.ReadKey();
                        }
                        Console.WriteLine("7!!!");
                        Console.WriteLine("вы получили 10 монет");
                        GOLD = GOLD + 10;
                        systematic[3] = 0;
                        RICHAG = 1;
                        break;
                    }
            }
        }
    }
    else if (VIBOR == 'q')
    {
        //скиллы
        //текущие скиллы
        //предметы
        //текущий предмет
        //Визуал//Визуал//Визуал//Визуал//Визуал//Визуал//Визуал//Визуал//Визуал//Визуал
        Console.WriteLine("СКИЛЛЫ");
        Console.WriteLine(" ");
        if (Rucoiatca == 0)
        {
            Console.WriteLine("пусто");
        }
        else if (Rucoiatca == 1)
        {
            Console.WriteLine("Удар рукояткой");
        }
        else if (Rucoiatca == 2)
        {
            Console.WriteLine("Удар рукояткой(занят)");
        }

        if (inventor_skills[0] == 0)
        {
            Console.WriteLine("пусто");
        }
        else if (inventor_skills[0] == 1)
        {
            Console.WriteLine("Поцелуй");
        }
        else if (inventor_skills[0] == 2)
        {
            Console.WriteLine("Поцелуй(занят)");
        }

        if (inventor_skills[1] == 0)
        {
            Console.WriteLine("пусто");
        }
        else if (inventor_skills[1] == 1)
        {
            Console.WriteLine("Лютая пятка");
        }
        else if (inventor_skills[1] == 2)
        {
            Console.WriteLine("Лютая пятка(занят)");
        }

        if (inventor_skills[2] == 0)
        {
            Console.WriteLine("пусто");
        }
        else if (inventor_skills[2] == 1)
        {
            Console.WriteLine("Яд");
        }
        else if (inventor_skills[2] == 2)
        {
            Console.WriteLine("Яд(занят)");
        }

        if (inventor_skills[3] == 0)
        {
            Console.WriteLine("пусто");
        }
        else if (inventor_skills[3] == 1)
        {
            Console.WriteLine("Молитва");
        }
        else if (inventor_skills[3] == 2)
        {
            Console.WriteLine("Молитва(занят)");
        }

        if (inventor_skills[4] == 0)
        {
            Console.WriteLine("пусто");
        }
        else if (inventor_skills[4] == 1)
        {
            Console.WriteLine("Подножка");
        }
        else if (inventor_skills[4] == 2)
        {
            Console.WriteLine("Подножка(занят)");
        }

        if (inventor_skills[5] == 0)
        {
            Console.WriteLine("пусто");
        }
        else if (inventor_skills[5] == 1)
        {
            Console.WriteLine("Собачий клык");
        }
        else if (inventor_skills[5] == 2)
        {
            Console.WriteLine("Собачий клык(занят)");
        }

        if (inventor_skills[6] == 0)
        {
            Console.WriteLine("пусто");
        }
        else if (inventor_skills[6] == 1)
        {
            Console.WriteLine("Набитый животик");
        }
        else if (inventor_skills[6] == 2)
        {
            Console.WriteLine("Набитый животик(занят)");
        }

        Console.WriteLine(" ");
        Console.WriteLine("ВЫБРАННЫЕ СКИЛЛЫ");
        Console.WriteLine(" ");

        if(Slots_Skills_zaniatost[0] == 1 && Slots_Skills[0] == 1)
        {
            Console.WriteLine("Удар рукояткой");
        }//можно было зделать легкче(условно)получается нужно ввести данные Число скилла и если оно открыто поставить её значение 2 потом число слота и если оно не занято внести значение индекса скилла в скилл_инвентор и зделать этот слот занятым,также и наоборот
        else if (Slots_Skills_zaniatost[0] == 1 && Slots_Skills[0] == 2)
        {
            Console.WriteLine("Поцелуй");
        }
        else if (Slots_Skills_zaniatost[0] == 1 && Slots_Skills[0] == 3)
        {
            Console.WriteLine("Лютая пятка");
        }
        else if (Slots_Skills_zaniatost[0] == 1 && Slots_Skills[0] == 4)
        {
            Console.WriteLine("Яд");
        }
        else if (Slots_Skills_zaniatost[0] == 1 && Slots_Skills[0] == 5)
        {
            Console.WriteLine("Молитва");
        }
        else if (Slots_Skills_zaniatost[0] == 1 && Slots_Skills[0] == 6)
        {
            Console.WriteLine("Подножка");
        }
        else if (Slots_Skills_zaniatost[0] == 1 && Slots_Skills[0] == 7)
        {
            Console.WriteLine("Собачий клык");
        }
        else if (Slots_Skills_zaniatost[0] == 1 && Slots_Skills[0] == 8)
        {
            Console.WriteLine("Набитый животик");
        }
        else if(Slots_Skills_zaniatost[0] == 0)
        {
            Console.WriteLine("Пусто");
        }
        if (Slots_Skills_zaniatost[1] == 1 && Slots_Skills[1] == 1)
        {
            Console.WriteLine("Удар рукояткой");
        }
        else if (Slots_Skills_zaniatost[1] == 1 && Slots_Skills[1] == 2)
        {
            Console.WriteLine("Поцелуй");
        }
        else if (Slots_Skills_zaniatost[1] == 1 && Slots_Skills[1] == 3)
        {
            Console.WriteLine("Лютая пятка");
        }
        else if (Slots_Skills_zaniatost[1] == 1 && Slots_Skills[1] == 4)
        {
            Console.WriteLine("Яд");
        }
        else if (Slots_Skills_zaniatost[1] == 1 && Slots_Skills[1] == 5)
        {
            Console.WriteLine("Молитва");
        }
        else if (Slots_Skills_zaniatost[1] == 1 && Slots_Skills[1] == 6)
        {
            Console.WriteLine("Подножка");
        }
        else if (Slots_Skills_zaniatost[1] == 1 && Slots_Skills[1] == 7)
        {
            Console.WriteLine("Собачий клык");
        }
        else if (Slots_Skills_zaniatost[1] == 1 && Slots_Skills[1] == 8)
        {
            Console.WriteLine("Набитый животик");
        }
        else if (Slots_Skills_zaniatost[1] == 0)
        {
            Console.WriteLine("Пусто");
        }
        if (Slots_Skills_zaniatost[2] == 1 && Slots_Skills[2] == 1)
        {
            Console.WriteLine("Удар рукояткой");
        }
        else if (Slots_Skills_zaniatost[2] == 1 && Slots_Skills[2] == 2)
        {
            Console.WriteLine("Поцелуй");
        }
        else if (Slots_Skills_zaniatost[2] == 1 && Slots_Skills[2] == 3)
        {
            Console.WriteLine("Лютая пятка");
        }
        else if (Slots_Skills_zaniatost[2] == 1 && Slots_Skills[2] == 4)
        {
            Console.WriteLine("Яд");
        }
        else if (Slots_Skills_zaniatost[2] == 1 && Slots_Skills[2] == 5)
        {
            Console.WriteLine("Молитва");
        }
        else if (Slots_Skills_zaniatost[2] == 1 && Slots_Skills[2] == 6)
        {
            Console.WriteLine("Подножка");
        }
        else if (Slots_Skills_zaniatost[2] == 1 && Slots_Skills[2] == 7)
        {
            Console.WriteLine("Собачий клык");
        }
        else if (Slots_Skills_zaniatost[2] == 1 && Slots_Skills[2] == 8)
        {
            Console.WriteLine("Набитый животик");
        }
        else if (Slots_Skills_zaniatost[2] == 0)
        {
            Console.WriteLine("Пусто");
        }
        //осталось реализовать постановку скиллов


    }
}