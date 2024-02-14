#region Task_1
//Verilmiş düzbucaqlı şkafın hər hansı bir qapıdan keçib-keçməyəcəyini tapan algoritm yazın
//Console.WriteLine("Duzbucaqli Skafin Eni-ni daxil edin: ");
//int duzbucaqlinin_eni = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Duzbucaqli Skafin Uzunglugunu-ni daxil edin: ");
//int duzbucaqliqnin_uzunlugu = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Qapinin Sahesini daxil edin: ");
//int qapinin_sahesi = Convert.ToInt32(Console.ReadLine());
//int duzbucaqlinin_sahesi = duzbucaqlinin_eni * duzbucaqliqnin_uzunlugu;
//if (duzbucaqlinin_sahesi < qapinin_sahesi)
//{
//    Console.WriteLine("Duzbucaqli Skaf Qapidan kececekdir!");
//}
//else
//{
//    Console.WriteLine("Duzbucaqli Skaf Qapidan kecmeyecekdir!");
//}
#endregion
#region Task_2
//Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın.
//Console.WriteLine("Musbet Tam Ededinizi Daxil Edin: ");
//double n=Convert.ToDouble(Console.ReadLine());
//// 2,4,8,16,32,64,128,256,512,1024,2048,4096,8192
//int count = 0;

//while (n > 0)
//{

//    n = n / 2;
//    if (n == 1)
//    {
//        Console.WriteLine("quvvetidir");
//        break;
//    }
//    else if (n % 2 == 1)
//    {
//        Console.WriteLine("quvveti deyil");
//        break;
//    }


//}
#endregion
#region Task_3
//Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5   
Console.WriteLine("Ededinizi daxil edin");
int eded = Convert.ToInt32(Console.ReadLine()); //23452
int count = 0;
while (eded > 0)
{
    eded = eded / 10;
    count++;
}
Console.WriteLine(count);
#endregion