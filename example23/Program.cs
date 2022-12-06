// Math.Round(new Random().Next(0, 10) + new Random().NextDouble(), 2);
// arr[i,j] = new Random().Next(0,10) + new Random().NextDouble();

// или
// Convert.ToDouble(x.Next(100)/10.0);

// как не нужно писать код

using System.Linq;

string text = "(1,2) (3,4) (5,6) (7,8)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(text);
var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0)
                .Select(point => (point.x * 10, point.y))
                .ToArray();
                
for (int i = 0; i < data.Length; i++)
{
    for (int k = 0; k < data.Length; k++)
{
    Console.WriteLine(data[i]);
}
    // Console.WriteLine(data[i]);
}