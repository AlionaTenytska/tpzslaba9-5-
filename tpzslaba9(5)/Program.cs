using System;

namespace tpzslaba9_5_
{
    class Program
    {
        delegate int UseOperation(int x, int y);

        delegate void GetGreeting();

        static void GoodMorning()
        {

            Console.WriteLine("Доброе утро!");

        }
        static void GoodDay()
        {

            Console.WriteLine("Добрый день!");

        }
        static void GoodEvening()
        {

            Console.WriteLine("Добрый вечер!");

        }
        static void GoodNight()
        {

            Console.WriteLine("Доброй ночи!");

        }

        static int Addition(int x, int y)
        {

            return x + y;

        }
        static int Subtraction(int x, int y)
        {

            return x - y;

        }
        static int Multiplycation(int x, int y)
        {

            return x * y;

        }

        static int Division(int x, int y)
        {

            return x / y;

        }
        

        static void Main(string[] args)
        {

            GetGreeting del;

            if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 15)
            {

                del = GoodDay;

            }
            else if (DateTime.Now.Hour >= 15 && DateTime.Now.Hour < 21)
            {

                del = GoodEvening;

            }
            else if (DateTime.Now.Hour >= 21 && DateTime.Now.Hour < 3)
            {

                del = GoodNight;

            }
            else
            {

                del = GoodMorning;

            }

            del.Invoke();

            UseOperation operation;

                Console.WriteLine("Введите два целых числа : ");

                int x = Convert.ToInt32(Console.ReadLine());

                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите знак операции");
                char op = (char)Console.Read();

                int result = 0;

                switch (op)
                {
                    case '+': operation = Addition; result = operation.Invoke(x, y); break;
                    case '-': operation = Subtraction; result = operation.Invoke(x, y); break;
                    case '/': operation = Division; result = operation.Invoke(x, y); break;
                    case '*': operation = Multiplycation; result = operation.Invoke(x, y); break;
                    default: Console.WriteLine("Неправильный формат ввода!"); break;
                }

                Console.WriteLine("Результат операции - {0}", result);

            Console.ReadKey();

        }  
    }
}
