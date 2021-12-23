using System;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___1 задание___");
            try
            {

                Console.Write("Введите день:");
                int d1 = int.Parse(Console.ReadLine());

                Console.Write("Введите месяц:");
                int m1 = int.Parse(Console.ReadLine());

                Console.Write("Введите год:");
                int y1 = int.Parse(Console.ReadLine());
                DateTime date1 = new DateTime(y1, m1, d1);

                Console.WriteLine("---------------------------");

                Console.WriteLine(date1.ToString("День: dd"));
                Console.WriteLine(date1.ToString("Месяц: MMM"));
                Console.WriteLine(date1.ToString("Год: yyyy"));

                Console.WriteLine("---------------------------");

                Console.WriteLine(date1.ToString("dd.MM.yyyy"));
                Console.WriteLine("---------------------------");
            }
            catch (Exception)
            {
                Console.WriteLine("Введите корректно");
            }

            Console.WriteLine("___2 задание___");

            Console.WriteLine("Введите дату производства продукта");
            Console.Write("Введите год:");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите день:");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите время производства продукта");
            Console.WriteLine("Введите часы:");
            int h2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минуты:");
            int m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите секунды:");
            int s2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите срок годности в часах:");
            int c = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(y, m, d, h2, m2, s2);


          
             Console.WriteLine("Кол-во оставшихся часов:", );
           

            else

                Console.WriteLine("Предупреждение! -Срок годности истек");
          
            

        }
    }
}