// собрать строку с числами от а до б, а <= b
// string NumbersFor(int a, int b)
// {
//         string result = String.Empty;
//         for (int i = a; i <= b; i++) // от большего к меньшему i >= b; i--
//         {
//             result += $"{i} ";
//         }
//         return result;
// }

// string NumberRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumberRec(a + 1, b); // от большего к меньшему NumberRec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }
// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 ... 10
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 ... 10
// додумать способ, чтобы на 1 вызов рекурсии было меньше
// подкрутить условие и ретурн написать несколько иначе

// сумма чисел от 1 до н

// int SumFor(int n)
// {
//         int result = 0;
//         for(int i = 1; i <= n; result += i);
//         return result;
// }
// // с рекурсией
// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumFor(10)); // 55
// Console.WriteLine(SumRec(10)); // 55

// факториал числа 
// int FactorialFor(int n) // итеративный подход
// {
//     int result = 1;
//     for(int i = 1; i <= n; result += i);
//     return result;
// }

// // рекурсия
// int FactorialRec(int n)
// {
//     if (n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialFor(10)); // 3628800
// Console.WriteLine(FactorialRec(10)); // 3628800

// возвести число в степень
// int a = 2;
// int n = 10;
// int PowerFor(int a, int n) // итеративный метод
// {
//     int result = 1;
//     for (int i = 0; i <= 0; result *= a);
//     return result;
// }

// рекурсия

// int PowerRec(int a, int n)
// {
//     // return n == 0 ? 1 : PowerRec(a, n - 1) * a; тоже самое, что и двумя строчками ниже, тернарный оператор
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// int PowerRecMath(int a, int n) // улучшение метода, вместо 27 операций выше, здесь будет всего 6 операций
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }
// Console.WriteLine(PowerFor(2, 10)); // 1024
// Console.WriteLine(PowerRec(2, 10)); // 1024
// Console.WriteLine(PowerRecMath(2, 10));

// перебор слов
// в нашем машинном алфавите есть {а и с в} 
// Покажите все слова, состоящие из T букв, 
// которые можно построить из букв этого алфавита

// итеративный метод

// char[] s = {'а', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for(int i = 0; i < count; i++) // однобуквенные слова
// {
//     for (int j = 0; j < count; j++) // двубуквенные слова
//     {
//     Console.WriteLine($"{n++, -5} {s[i]} {s[j]}");
//     }
//     // Console.WriteLine($"{n++, -5} {s[i]}");
// }

// рекурсия

// типа должны сами сделать


// есть 5 игроков нужно показать все разбиения игроков на 2 команды
// 0 - игрок в первой команде
// 1 - игрок во 2 команде
// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }

// }
// FindWords("аисв", new char[3]);

// показывает алгоритм обхода дериктории
// это значит что мы хотим посмотреть все папки
// и все файлы внутри папок
// string path = "C:/geekbrains/1lection/example3";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();
// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }

// string path = "C:/geekbrains/1lection/example3";
// CatalogInfo(path);


// игра в пирамидки

// void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();


// обход разных структур

// ((4 - 2) * (1 + 3)) / 10
// можем построить бинарное дерево (tree traversal)
// разложив всё выражение
// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// //                 0    1    2    3     4    5    6    7    8    9    10   11
// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }

// InOrderTraversal();

// где может использоваться
// html
// json
// xml
// разбор выражений
// анализ текста
// обход графа
// и т.д.

// decimal fRec = 0;
// decimal fIte = 0;
// decimal FibonacciRecursion(int n)
// {
//     fRec++;
//     return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
// }

// decimal FibonacciIteration(int n)
// {
//     fIte++;
//     decimal result = 1;
//     decimal f0 = 1;
//     decimal f1 = 0;
//     for (int i = 2; i <= n; i++)
//     {
//         result = f0 + f1;

//         f0 = f1;
//         f1 = result;
//         fIte++;
//     }
//     return result;
// }
// DateTime dt = DateTime.Now;
// // # 1 2 3 4 5 6
// // v 1 1 2 3 5 8
// Console.ReadLine();
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), - 15}");
//     fIte = 0;
// }
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// Console.WriteLine();
// Console.ReadLine();
// dt = DateTime.Now;
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), - 15}");
//     fRec = 0;
// }
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
// Console.ReadLine();
// домашка написать рекурсию для фибоначчи, но чтобы работало быстрее


int[,] pic = new int[10, 10];
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

for (int i = 0; i < 10; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 9] = 1;
    pic[9, i] = 1;
}

PrintImage(pic);
FillImage(1, 1);
Console.WriteLine();
PrintImage(pic);

void PrintImage(int[,] image)
{

    for (int i = 0; i < image.GetLength(0); i++)// matrix.GetLength(0) выдаёт количество строк
    {
        for (int j = 0; j < image.GetLength(1); j++)// matrix.GetLength(1) выдаёт количество столбцов
        {
            // Console.Write($"{matr[i, j]} ");
       if (image[i, j] == 0)
       {
        Console.Write($" ");
       }
       else
       {
        Console.Write("+");
       }
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row -1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}
PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);