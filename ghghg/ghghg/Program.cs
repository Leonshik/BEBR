int a = 32131;
    int d = 1;
    int x = 0;
Console.WriteLine(a);
Console.WriteLine(d);
x = a;
a = d;
d = x;

Console.WriteLine(a);
Console.WriteLine(d);
Console.WriteLine("");
 a = 6;
 d = 4;
a = a + d;//    :(
d = a - d;
a = a - d;
Console.WriteLine(a);
Console.WriteLine(d);

int AAAA = 0;
Random GO = new Random();
int[] mas = new int[10];
int govn = 0;
int y = 0;
int rrrr = 0;


int Shetchick = 0;

for (; y <= 9;)
{
        rrrr = GO.Next(0, 10); 
       if (rrrr != mas [0] && rrrr != mas[1] && rrrr != mas[2] && rrrr != mas[3] && rrrr != mas[4] && rrrr != mas[5] && rrrr != mas[6] && rrrr != mas[7] && rrrr != mas[8] )
       {
        mas[y] = rrrr;
        y++;     
       }    
}
int bebr = GO.Next(0, 9);
mas[bebr] = mas[bebr] + mas[9];
mas[9] = mas[bebr] - mas[9];
mas[bebr] = mas[bebr] - mas[9];
for (int vcedg = 0; vcedg < mas.Length ; vcedg ++)
{
    Console.Write(mas[vcedg]);
}
int RICHAG = 0;

while (RICHAG != 1)
{
    for (int coca = 0; coca <= 9; coca++)
    {
        int alt = coca + 1;
        if(alt > 9)
        {
            alt = 9;
        }
        if (mas[coca] > mas[alt])
        {
            mas[coca] = mas[coca] + mas[alt];
            mas[alt] = mas[coca] - mas[alt];
            mas[coca] = mas[coca] - mas[alt];
        }
        Shetchick++;
    }
    if(mas[0] < mas[1]&& mas[1] < mas[2]&& mas[2] < mas[3] && mas[3] < mas[4] && mas[4] < mas[5] && mas[5] < mas[6] && mas[6] < mas[7] && mas[7] < mas[8] && mas[8] < mas[9])
    {
        RICHAG = 1;
    }
}
Console.WriteLine(" ");
Console.WriteLine(Shetchick);
for (int vcedg = 0; vcedg < mas.Length; vcedg++)
{
    Console.Write(mas[vcedg]);
}


Console.WriteLine(" ");

int Gobabl;
int[] babl = new int[] { 10, 10, 10, 10, 10, 10, 10, };
int itogovo;
int ogo = 0;
int bablo =100;
int summa = 0;
int it;
int pred_it = 0;
int iteraciia = 0;
int item = 1;

for (int Stop = 0; Stop != 1;iteraciia++)
{
    for (int g = 0; g <= 6; g++)
    {
        itogovo = GO.Next(0, 11);
        if (itogovo == 0)
        {
            ogo = -5;
        }
        else if (itogovo == 10)
        {
            ogo = 5;
        }
        else if (itogovo == 1 || itogovo == 2)
        {
            ogo = -3;
        }
        else if (itogovo == 9 || itogovo == 8)
        {
            ogo = 3;
        }
        else if (itogovo == 3 || itogovo == 4)
        {
            ogo = -1;
        }
        else if (itogovo == 7 || itogovo == 6)
        {
            ogo = 1;
        }

        Gobabl = g - 1;
        if (Gobabl < 0)
        {
            Gobabl = 0;
        }

        babl[g] = babl[Gobabl] + ogo;
        if (babl[g] < 0)
        {
            babl[g] = 1;
        }
    }

    for (int vcedg = 0; vcedg < babl.Length; vcedg++)
    {

        Console.Write(babl[vcedg]);
        Console.Write(" ");
    }
    summa = 0;
    for (int u = 0; u <= 6; u++)
    {
        summa = summa + babl[u];
    }
    it = summa / 7;
    Console.WriteLine(" ");
    Console.WriteLine(it);
    Console.WriteLine("Операция " +iteraciia);
    if (iteraciia != 0)
    {
        if(pred_it < it)//UP
        {
            if (!(item <= 0))
            {
                item--;
                bablo = bablo + babl[6];
                Console.WriteLine("Была совершена продажа");
                Console.WriteLine(bablo + " money");
            }
            else
            {
                Console.WriteLine("Продавать нечего");
            }
        }
        else if(pred_it > it)//DOWN
        {
            if(bablo >= babl[6])
            {
                item++;
                bablo = bablo - babl[6];
                Console.WriteLine("Была совершена покупка");
                Console.WriteLine(bablo + " money");
            }
            else
            {
                Console.WriteLine("Денег нет");
            }
        }
            
    }
    pred_it = it;
    Console.ReadKey();
    if(iteraciia == 500 || (bablo <= 0 && item ==0))
    {
        Stop = 1;
    }
}
Console.WriteLine("ваша прибыль :");
Console.WriteLine(bablo - 100);



