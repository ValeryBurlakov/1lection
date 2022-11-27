// рекурсия

// 1. факториал можно решить рекурсией

// double Factorial(int n)
// {
//    // 1! = 1
//    //  0! = 1
//      if (n == 1) return 1;
//      else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");//1*2*3 = 6
// }
// при таком коде переполняется тип данных integer на 17 и появляется отрицательный знак
// для решения в 3 строке мы применили тип double, который смог переварить такие большие числа

// 2. Числа фибоначчи
// Fn = Fn-1 + Fn-2
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2); // return потому что нам нужно вернуть значение
// }

// for(int i = 1; i < 10; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }


// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2); // return потому что нам нужно вернуть значение
// }

// for(int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f{i} = {Fibonacci(i)}");
// }
// очень медленно работает

// 3. Обход директорию рекурсией
