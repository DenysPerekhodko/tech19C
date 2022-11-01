//zad1
//Console.WriteLine("Pn\tBt\tSr\tCzw\tPt\tSob\tNd\t");
//Console.Write("\t");
//int j = 1;
//for (int i = 1; i < 31; i++)
//{
//    Console.Write(i + "\t");
//    j++;
//    if (j == 7)
//    {
//        Console.WriteLine();
//        j = 0;
//    }

//}

//zad2
//int k2 = int.Parse(Console.ReadLine());
//for (int i = 1; i < k2 * 2; i++)
//{
//    if (i % 2 == 1)
//    {
//        Console.WriteLine(i * i);
//    }
//}

//zad3
//for (int i = 1; i < 10001; i++)
//{
//    if (i % 379 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//zad4
//for (int i = 100; i < 1000; i++)
//{
//    if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//zad5
//int m = int.Parse(Console.ReadLine());
//int n = 0;
//int S = 0;
//for (int i = 1; i <= m; i++)
//{
//    n = int.Parse(Console.ReadLine());
//    S += n;
//}
//Console.WriteLine(S);   

//zad6
//int n = int.Parse(Console.ReadLine());
//int m = 0;
//for (int i = 2; i <= n*2; i+=2)
//{
// m+=i;
//}
//Console.WriteLine(m);
//
//zad7
//int n = int.Parse(Console.ReadLine());
//int d = 0;
//for (int i = 11; i <= n * 2 + 11; i += 2)
//{
//    d += i;  
//}
//Console.WriteLine(d);

//zad8

//int a = int.Parse(Console.ReadLine());
//double L = Convert.ToDouble(Console.ReadLine());
//double b = a;
//for (int i = 0; i < L * 12; i++)
//{
//    b = a * 0.06 * 1/12;
//    b+=a;
//}
//System.Console.WriteLine(Math.Round(b,2));

//zad9

//int L = int.Parse(Console.ReadLine());
//int k = 21;
//int s = 0;
//for (int i = 0; i < L; i++)
//{
//    for (int j = 0; j < i; j += k)
//    {
//        s += k;
//        k += 100;
//    }
//}
//System.Console.WriteLine(s);

//zad10

for (double i = 1; i <= 1000; i++)
{
    if (i % 10 == Math.Sqrt(i))
    {
        System.Console.WriteLine(i);
    }
    else if(i % 100 == Math.Sqrt(i))
    {
        System.Console.WriteLine(i);
    }
}