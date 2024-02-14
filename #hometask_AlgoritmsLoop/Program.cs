// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Task1
//Console.WriteLine("N daxil et:");

//int n = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("M daxil edt:");
//int m = Convert.ToInt32(Console.ReadLine());

//if (n >= m)
//{
//    Console.WriteLine("Xeta N m den kisin olmalidir");
//    return;
//}

//int sum = 0;

//for (int i = n; i<= m; i++)
//{
//    if(i % 2 != 0)
//    {
//        sum++;
//    }
//}

//Console.WriteLine("N ve m arasinda " +sum+ "tek eded var");

#endregion

#region task 2
//Console.Write("n tam ədədini daxil edin: ");
//int n = Convert.ToInt32(Console.ReadLine());

//if (n <= 1)
//{
//    Console.WriteLine("Xeta: n 1-den buyuk bir eded olmalidir.");
//    return;
//}

//bool sum = true;

//for (int i = 2; i < n; i++)
//{
//    if (n % i == 0)
//    {
//        sum = false;

//    }
//}

//if (sum)
//{
//    Console.WriteLine(n + " sade ");
//}

//else
//{
//    Console.WriteLine(n + " Murekkeb ");
//}

#endregion

#region task3
//Console.WriteLine("A daxil et:");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("B daxil et:");
//int b = Convert.ToInt32(Console.ReadLine());

//if (a % b == 0)
//{
//    Console.WriteLine("Tam Bolunur");
//}

//else
//{
//    Console.WriteLine("Bolunmur");
//}
#endregion

#region taks4 market
Console.Write("Birinci məhsulun qiymətini daxil edin: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci məhsulun qiymətini daxil edin: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü məhsulun qiymətini daxil edin: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int enUcuzQiymet = a;

        if (b < enUcuzQiymet)
        {
            enUcuzQiymet = b;
        }

        if (c < enUcuzQiymet)
        {
            enUcuzQiymet = c;
        }

        int toplamQiymet = a + b + c - enUcuzQiymet;

        Console.WriteLine("Müştəri ödəməli olduğu məbləğ: " + toplamQiymet + " manat");
#endregion