// See https://aka.ms/ne.w-console-template for more information
// Console.Write("Дароу, ты хто?!");
// var username = Console.ReadLine();
// Console.Write("Привет, ");
// Console.Write(username);

// double number1 = 40;
// double number2 = 5;

// double res = number1 / number2;

// Console.WriteLine(res);

// Console.Write("Введите имя пользователя: ");
// string username = Console.ReadLine();
// username.ToLower();
// if (username == "маша"){
//     Console.Write("Умри, сволочь!");
// }
// else
// {
//     Console.Write("Привет " + username);
// }

// int a = 3;
// int b = 5;
// int c = 8;
// int d = 12;
// int f = 1;

// int max = 0;

// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (f > max) max = f;

// Console.Write(max);

Console.Clear();

int xa = 50;
int ya = 1;
int xb = 1;
int yb = 20;
int xc = 100;
int yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa;
int y = ya;

int count = 0;

while(count < 100000)
{
    int randot = new Random().Next(0, 3);
    if (randot == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }

    if (randot == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }

    if(randot == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine('+');
    count++;
}