using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgoAndData
{
    class Program
    {

        //public int ref mainint = 0;


        static void Main(string[] args)
        {
            //Start:
            MyClass mc=new MyClass();
            int qwe = 0;
            string ms="";
             Console.WriteLine("Выберите задачу: \n 1. Рассчитать и вывести индекс массы тела \n 2. Найти максимум из четырех чисел \n 3. Написать программу обмена значений \n 5. Определение времени года \n 8. Вывести квадраты и кубы чисел от а до б");
             qwe = Convert.ToInt32(Console.ReadLine());
            switch(qwe)
            {
                case 1: mc.one();
                    break;
                case 2:
                    mc.two();
                    break;
                case 3:
                    mc.three(); 
                    break;
                     case 5:
                    mc.five();
                    break;
                case 8:
                    mc.eight();
                    break;
                default: ms = "К сожалению данная задача не выполнена";
                    break;

            }
            Console.WriteLine(ms);
            
           
            

          
            
           
           
            
            Console.ReadKey();
        }

       



        }

    }
    public class MyClass
    {

         public float i, m, h, test; // где i- индекс массы, m-масса тела в кг, h-рост в метрах
         public string inter;
         public double i2, m2, h2; // где i- индекс массы, m-масса тела в кг, h-рост в метрах



        public void one()
        {
             Console.WriteLine("Расчет индекса массы тела");
             Console.Write("Введите ваш вес в кг: ");
             inter = Console.ReadLine();
             m = Convert.ToSingle(inter);
            
             Console.Write("Введите ваш рост в метрах(Пример 1,8): ");
             inter = Console.ReadLine();
             h = Convert.ToSingle(inter);
            
             i = m / Convert.ToSingle(Math.Pow(h,2));

             Console.WriteLine($"Индекс массы вашего тела равен: {i} ");

       // goto Start;
         }

        public double a, b, c, d, max;
    public void two()
    {
        Console.WriteLine("Найти максимальное число из четырех чисел");
        Console.Write("Введите первое число");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите третье число");
        c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите четвертое число");
        d = Convert.ToDouble(Console.ReadLine());

        max = a;

        if (max < b) max = b;
        if (max < c) max = c;
        if (max < d) max = d;

        Console.WriteLine($"Максимальное из 4х чисел {max}");
        //for (int i = 0; i < 3; i++)
        //{
        //    if(i>)
        //}


        //inter = Console.ReadLine();
        //for(int i =0;i<inter.Length;i++)
        //{

        //}


        //}
    }

    public int t1,t2,t3;
    public void three()
    {
        Console.WriteLine("Обмен значениями ");
        Console.WriteLine("ВВедите 2 числа");
        Console.Write("Введите персое число: ");
        t1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе  число: ");
        t2 = Convert.ToInt32(Console.ReadLine());
        t3 = t1;
        t1 = t2;
        t2 = t3;
        Console.WriteLine("t3=t1 \n t1=t2 \n t2=t3");
        Console.WriteLine($"t1={t1} \n t2={t2} \n t3={t3}");

        Console.WriteLine("ВВедите 2 числа");
        Console.Write("Введите персое число: ");
        t1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе  число: ");
        t2 = Convert.ToInt32(Console.ReadLine());
        t1 = t1+t2;
        t2 = t1-t2;
        t1 = t1-t2;
        Console.WriteLine("t1 = t1 + t2 \n t2 = t1-t2 \n t1 = t1-t2");
        Console.WriteLine($"t1={t1} \n t2={t2}");

    }

    public int f1;
    public string fs1;
    public void five()
    {

        Console.WriteLine("введите номер месяца");
        f1 = Convert.ToInt32(Console.ReadLine());
        switch (f1)
        {
            case 1:
            case 2:
            case 12: fs1 = "Зама";
                break;
            case 3:
            case 4:
            case 5:
                fs1 = "Весна";
                break;
            case 6:
            case 7:
            case 8:
                fs1 = "Лето";
                break;
            case 9:
            case 10:
            case 11:
                fs1 = "Осень";
                break;
            default:
                fs1 = "Введите номер месяца от 1 до 12";
                break;
        }
        Console.WriteLine(fs1);
                if(f1<1 || f1>12)
        { five(); }

        
    }


    public int e1, e2;
    public void eight()

    {
        Console.WriteLine("Ввести а и б и вывести квадраты и кубы чисел от а до б");
        Console.Write("Введите персое число: ");
        e1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе  число: ");
        e2 = Convert.ToInt32(Console.ReadLine());
        for(int i=e1;i<=e2;i++)
        {
            Console.WriteLine($"квадрат числа {i} = {Math.Pow(i,2)}, куб числа {i} = {Math.Pow(i,3)}");
        }
    }    
}
