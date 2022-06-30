/*
void kub()                                                                            //Задача 23
{
    Console.WriteLine("Введите кол-во кубических значений");
    int x = Convert.ToInt32(Console.ReadLine());
    int Count = 0;
    int y;
    int z = 1;
    while (Count<x)
    {
        y=z*z*z;
        Console.WriteLine(y);
        z++;
        Count++;
    }
}
kub();
*/

/*
void rasstoyniev3D()                                                                  //Задача 21
{
    Console.WriteLine("Введите кординаты точки А, в такой последовательности: x, y, z (после написания каждой из кординат нажимайте Enter");                    
        int xa = Convert.ToInt32(Console.ReadLine());
        int ya = Convert.ToInt32(Console.ReadLine());
        int za = Convert.ToInt32(Console.ReadLine());
        
    Console.WriteLine("Введите кординаты точки B, в такой последовательности: x, y, z (после написания каждой из кординат нажимайте Enter");
        int xb = Convert.ToInt32(Console.ReadLine());
        int yb = Convert.ToInt32(Console.ReadLine());
        int zb = Convert.ToInt32(Console.ReadLine());
    
    double AF = ya - yb;
    double AF2 = AF * AF;
    double FC = xb - xa;
    double FC2 = FC * FC;
    double AC2 = AF2 + FC2;
    double AC = Math.Sqrt(AC2);
    
    double BC = zb - za;
    double BC2 = BC * BC;
    
    double AB2 = AC2 + BC2;
    double AB = Math.Sqrt(AB2);
    Console.WriteLine("Длина вашего отрезка = " + AB);
}
rasstoyniev3D();
*/

/*
int polindrom()                                                                         //Задача 19
{
    Console.WriteLine("Введите пятизначное число:");
    int s = Convert.ToInt32(Console.ReadLine());
    string s1 = Convert.ToString(s);
        if (s1[0] == s1[4])
            {
                if (s1[1] == s1[3]) return 1;
                else return 0;
            }
        else return 0;
}
int x = polindrom();
    if (x == 1) 
    {
        Console.WriteLine("Число являеться полиндромом");
    }
    else Console.WriteLine("Число не являеться полиндромом");
*/

