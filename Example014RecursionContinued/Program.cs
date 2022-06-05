// Рекурсивная функция - это функция, 
// вызввающая сама себя!!!

/* // Задача 1: Собрать строку с числами от A до B, а <= b.

// Итаративный метод.
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
// Рекурсия
string NumbersRes(int c, int d)
{
    if (c <= d) return $"{c} " + NumbersRes(c + 1, d);
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRes(1, 10));

// от большего к меньшему.
// Итаративный метод.
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
// Рекурсия
string NumbersRes(int c, int d)
{
    if (c <= d) return   NumbersRes(c + 1, d)+$"{c} ";
    else return String.Empty;
}
*/

/* // Задача 2: Сумма чисел от 1 до n;
// Итаративный метод.
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
// Рекурсия
int SumRec(int n)
{
    if (n == 1) return 1;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));
*/
/*
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if(n == 1) return 1;
    else return n * FactorialRec(n-1);
}
Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800
*/
/*
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{  // return n == 0 ? 1: PowerRec(a,n-1)*a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n%2 == 0)return PowerRecMath(a*a, n / 2);
    else return PowerRecMath(a,n-1)*a;
}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024
*/
/*
char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}");
        }
    }
}
*/
/*
int n = 1;
void FindWords(string alphabet, char[] word, int length =0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet,word,length +1);
    }
}
FindWords("аисв", new char[5]);
*/

// string path = "/Users/dj_vo/Desktop/EXMPLES1/Example001_HelloConsole";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();
// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }
/*
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }

}
string path = "C:/Users/dj_vo/Desktop/EXMPLES1";
CatalogInfo(path);
*/
/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} 21>> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();
*/
/*
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2      3    4    5    6    7   8    9    10   11
void InOrderTraversal(int pos = 1)
{
    if(pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.Write(tree[pos]+" ");
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);

    }
}
InOrderTraversal();
*/
/*
decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1= result;
        fIte++;
    }
    return result;
}


//# 1 2 3 4 5 6
//V 1 1 2 3 5 8

Console.ReadLine();

DateTime dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();
dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
*/
/*
int i = 0;
void Rec()
{
    System.Console.WriteLine(i++);
    Rec();
}

Rec();
*/
/*
int[,] pic = new int[1000,1000];
for (int i = 0; i < 1000; i++)
{
    pic[0,i] = 1;
    pic[i,0] = 1;
    pic[i,999] = 1;
    pic[999,i] = 1;  
}
// PrintImage(pic);
FillImage(1,1);
Console.WriteLine();
// PrintImage(pic);

void PrintImage(int[,] imege)
{
    for (int i = 0; i < imege.GetLength(0); i++)
    {
        for (int j = 0; j < imege.GetLength(1); j++)
        {
            //Console.Write($"{imege[i, j]} ");
            if (imege[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
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
*/
