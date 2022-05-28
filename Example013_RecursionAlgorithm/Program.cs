//Двумерные или многомерные массивы.
/*
string[,] table = new string[5, 5];
// String.Empty
// table [0,0] teble [0,1] table [0,2] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,4]
table[0, 0] = String.Empty;
for (int rows = 0; rows < 5; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }

}
*/




/* void PrintArray(int[,] imege)
{
    for (int i = 0; i < imege.GetLength(0); i++)
    {
        for (int j = 0; j < imege.GetLength(1); j++)
        {
            Console.Write($"{imege[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray(int[,] imege)
{
    for (int i = 0; i < imege.GetLength(0); i++)
    {
        for (int j = 0; j < imege.GetLength(1); j++)
        {
            imege[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] imegeix = new int[3, 4];
PrintArray(imegeix);
FillArray(imegeix);
PrintArray(imegeix);
*/

/* int[,] pic = new int[,]
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};


void PrintImage(int[,] imege)
{
    for (int i = 0; i < imege.GetLength(0); i++)
    {
        for (int j = 0; j < imege.GetLength(1); j++)
        {
            //Console.Write($"{imege[i, j]} ");
            if (imege[i, j] == 0) Console.Write($" ");
            else Console.Write($"0");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}
void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}
PrintImage(pic);
FillImage(13,13);
PrintImage(pic);
*/

/*
// Факториал
// 5!=5*4*3*2*1
//       5*4!
//         4*3!
//           3*2!

 int Factorial(int n)
{
    //1!=1
    //0!=1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i <= 40; i++)
{
    Console.WriteLine($"{i}! -> {Factorial(i)}");
}
*/


// Фибоначи:
// f(0) = 0;
// f(1) = 1;
// f(2) = 1;
// f(n) = f(n-1) + f(n-2);

/* int Fibonacci(int n)
{
    if(n==1||n ==2) return 1;
    else return Fibonacci(n-1)+Fibonacci(n-2);
}
for (int i = 1; i <= 50; i ++)
{
    Console.WriteLine($" F({i}) = {Fibonacci(i)};");
}
*/
/* Console.Clear();
Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


void MetodFibonacci()
{
    int fibonacci0 = 0;
    int fibonacci1 = 1;
    int fibonacciSum = 0;
    Console.WriteLine($"F({0}) = {fibonacci0};"); 
    Console.WriteLine($"F({1}) = {fibonacci1};");
    for (int i = 2; i <= Num; i++)
    {
        fibonacciSum = fibonacci0 + fibonacci1;
        fibonacci0 = fibonacci1;
        fibonacci1 = fibonacciSum;
        Console.WriteLine($"F({i}) = {fibonacciSum}; ");
    }
    
    
}
MetodFibonacci();
Console.WriteLine();
*/

