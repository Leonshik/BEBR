using System;
int[] kakashka1 = new int[9];
int[,] kakashka = new int[3,3];
int r = 0;
int h = 0;
int v = 0;
for (; r <= 2; r++)
{
    h = 0;
    for (; h <= 2; h++)
    {
        kakashka[r, h] = 3;
        Console.Write(kakashka[r,h]);
        Console.Write(" ");
    }
}
r = 0;
for (;r <=2;r++)
{
    h = 0;
    for (;h <=2; h++)
    {
        kakashka1[v] = kakashka[r, h];
        v++;        
    }
}
for (int vcedg = 0; vcedg < kakashka1.Length; vcedg++)
{

    Console.Write(kakashka1 [vcedg]);
    Console.Write(" ");
}

