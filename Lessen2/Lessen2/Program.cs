using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessen2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            MyClass mc = new MyClass();
            Console.WriteLine("Выберите задание \n 1. Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию. \n 2. Реализовать функцию возведения числа a в степень b");
            i = Convert.ToInt32(Console.ReadLine());
            switch(i)
            {
                case 1: mc.task_one();
                    break;
                case 2:
                    mc.task_two();
                    break;
                default: Console.WriteLine("К сожалению данное задание не выполнено");
                    break;
                    

            }
           
            
            //double res1;
            //int res2;
            //res1 = 73 / 2;
            //res2 = 73 / 2;

            //Console.WriteLine($"{res1}  {res2}");
            //res1 = res1 / 2;
            //res2 = res2 / 2;
            


            Console.ReadKey();
        }

        
    }

    class MyClass
    {  /// <summary>
       /// 1.Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.
       /// </summary>

        #region
        public void task_one()
        {
            double desyatichnaya;
            string result="";
            Console.WriteLine("Функция перевода из десятичной системы в двоичную");
            Console.WriteLine("Введите десятичное число ");
            desyatichnaya = Convert.ToDouble(Console.ReadLine());
            result = recursion_one(desyatichnaya,result);

            Console.WriteLine($"Двоичное представление числа {desyatichnaya} =   {result}");




        }

        public string recursion_one(double rec,string result)
        {
            string res = result;
            if (rec > 0)
            {
                if (rec % 2 == 0)
                {
                    rec /= 2;
                    res += "0";
                    //Console.WriteLine($"res={rec} ");
                    //Console.WriteLine($"res={res} ");
                    return recursion_one(Math.Round(rec), res);
                }
                else
                {
                    rec /= 2;
                    res += "1";
                    //Console.WriteLine($"res={rec} ");
                    return recursion_one(Math.Round(rec), res);
                }
            }
            return res;

            
        }


        #endregion




        /// <summary>
        /// 2. Реализовать функцию возведения числа a в степень b:
        ///      a.без рекурсии;
        ///      b.рекурсивно;
        /// </summary>
        #region
        public void task_two()
        {
            int a, b, result,basic;
            Console.WriteLine("Функция возведения числа в степерь, в текущей реализации только целые числа");
            Console.WriteLine("Введите число а");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите степень в которое будет возведено число {a}");
            b = Convert.ToInt32(Console.ReadLine());
            basic = a;
            result = Convert.ToInt32(Math.Pow(a, b));
            Console.WriteLine($"При использовании Math.Pow(a,b)={result}");
            result = recursion(a, b,basic);
            Console.WriteLine($"При использовании метода ={result}");
        }
        public int recursion(int a, int b, int basic)
        {
            int i = b;
            int result = a;

            if (i > 1)
            {
                result *= basic;
                --i;
                
              
                return recursion(result, i, basic);
            }
            else
            {
                return result;
            }
            





        }
        #endregion
    }



}
