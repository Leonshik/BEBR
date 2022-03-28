using System;
// :(
int t;
int.TryParse(Console.ReadLine(), out t);
Console.WriteLine("Array Z - " + t);
int f;
int.TryParse(Console.ReadLine(), out f);
Console.WriteLine("Array Y - " + f);
int g;
int.TryParse(Console.ReadLine(), out g);
Console.WriteLine("Array X - " + g);
int[,,] Arr = new int[t,f,g];
// :(
int if_;
int.TryParse(Console.ReadLine(), out if_);
Console.WriteLine("Hotelka - " + if_);
// :(
Console.WriteLine("hotelka");

int i;
int.TryParse(Console.ReadLine(), out i);
int ii;
int.TryParse(Console.ReadLine(), out ii);
int iii;
int.TryParse(Console.ReadLine(), out iii);
Console.WriteLine(i+","+ii+","+iii);
int hotelka2 = ((f * g) * i) + ((ii * f )+ iii);
Console.WriteLine("ITOG - " + hotelka2);






string text = "абфпцсвгд";
int u2;
int r = 0;
int sh = 0;
int u = 0;
for (int op = 0; op <= 100; op++)
{
    Console.WriteLine(op);
    r = 0;
    for (u = 0; u < text.Length; u++)
    { 
        sh = 0;
        for (u2 = u + 1; u2 < text.Length; u2++)
        {
            if (text[u] < text[u2])
            {
                text = text.Substring(0, r) + text.Substring(u + 1, sh) + text[u] + text.Substring(u2);
                u2 = 100;
                continue;
            }
            sh++;
        }
        r++;
    }
}
Console.WriteLine(text);