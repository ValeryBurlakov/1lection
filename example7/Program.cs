// 1 определить 3 точки, 2 выбрать выбрать 2 любых, 3 найти середину, 4 поставить точку, 5 выбрать случайную вершину треугольника, 6 соеденить её с полученной на 4 шаге точкой, 7 перейти к шагу 3, 8 шаги 3-7 повторить 9, 28, 31 раз
Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("*");

int xa = 30;
int ya = 1;
int xb = 1;
int yb = 15;
int xc = 60;
int yc = 15;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x = xa, y = xb;

int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3); //0 3, 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;    }
        Console.SetCursorPosition(x, y);
        Console.WriteLine("*");
        count = count + 1;
}
// фрактальное изображение треугольник серпинского
