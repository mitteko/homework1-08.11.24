using System;
using System.IO.Pipes; //библиотека - можно использовать разный функционал внутри самого файла


namespace Homework //пространство имен - набор связанных классов

{

    class Program

    {

        static void Main() //метод, точка входа (без нее проект не будет запущен, выполняет код, который написан внутри этой функции)

        {
            
            Console.WriteLine("1)");
            double e = Math.E;
            Console.WriteLine($"{e:f1}"); /* выражение e с форматом f1; f1 — это форматный спецификатор;:f1 — это указание на формат числа.
                                          переменная e — это число с плавающей точкой (например, double(двойная точность) или float(одинарная)), 
                                          f — формат с фиксированной точкой;
                                          плавающая точка — способ представления чисел с десятичной дробью в компьютерах, который позволяет эффективно хранить как очень большие, так и очень маленькие числа */



            Console.WriteLine("2)");
            Console.WriteLine("50");
            Console.WriteLine("10");



            Console.WriteLine("3)");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);



            Console.WriteLine("4)");
            int number;                          // объявление переменной типа int, которая будет хранить целое число
            string ten = Console.ReadLine();
            if (int.TryParse(ten, out number))   /* int.TryParse пытается преобразовать эту строку в целое число; если преобразование успешно, значение сохраняется в переменной number
                                                 out number указывает, что переменная number передаётся в метод TryParse как выходной параметр.
                                                 если TryParse успешно преобразует строку в число, он сохраняет результат в переменную number */
            {
                Console.WriteLine(number+10);
            }


            Console.WriteLine("5)");
            double name;
            string P = Console.ReadLine();
            if (double.TryParse(P, out name))
            {
                double qw = name * 4;
                Console.WriteLine("Периметр:"+qw);
            }



            Console.WriteLine("6)");
            int n;
            Console.Write("Введите радиус:");
            string R = Console.ReadLine();
            
            if (int.TryParse(R, out n))
            {
                double q = n * 3.14;              //double - хранение чисел с плавающей точкой, которые требуют большей точности, чем целые числа int
                double w = n * n * 3.14;
                Console.WriteLine("Длина окружности:"+q);
                Console.WriteLine("Площадь круга:"+w);
            }



            Console.WriteLine("7)");
            double x;
            string qwe = Console.ReadLine();
            if (double.TryParse(qwe, out x))
            {
                double radians = x * Math.PI / 180;
                double y = Math.Cos(x);
                Console.WriteLine(y);
            }



            Console.WriteLine("8)");
            Console.WriteLine("Основание 1:");
            string osn1 = Console.ReadLine();
            Console.WriteLine("Основание 2:");
            string osn2 = Console.ReadLine();
            Console.WriteLine("Высота:");
            string vis = Console.ReadLine();
            double num1;
            double num2;
            double num3;
            if (double.TryParse((osn1), out num1) && double.TryParse((osn2), out num2) && double.TryParse((vis), out num3))
            {
                double Perimetr = (num3 * (num2 + num1)/2);
                Console.WriteLine("Периметр равен " + Perimetr);
            }



            Console.WriteLine("9)");
            Console.WriteLine("Стоимость:");
            double candies = Convert.ToDouble(Console.ReadLine());
            double cookies = Convert.ToDouble(Console.ReadLine());
            double apples = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Кг:");
            double kgx = Convert.ToDouble(Console.ReadLine());
            double kgy = Convert.ToDouble(Console.ReadLine());
            double kgz = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(candies * kgx + cookies * kgy + apples * kgz);



            Console.WriteLine("10)");
            Console.Write("Мир ");
            Console.Write("Труд ");
            Console.WriteLine("Май ");
            Console.WriteLine("Мир");
            Console.WriteLine("Труд".PadLeft(7));
            Console.WriteLine("Май".PadLeft(11));



            Console.WriteLine("11)");
            
            Console.WriteLine("Первое число:");
            string rt = Console.ReadLine();
            if (rt.Contains(','))
            {
                rt = rt.Replace(',', '.');
            }
            Console.WriteLine("Второе число:");
            string ut = Console.ReadLine();
            if (ut.Contains(','))
            {
                ut = ut.Replace(',', '.');
            }

            double number1;                                                                   //???????????????????????????????????????
            double number2;

            if (double.TryParse(rt, out number1) && double.TryParse(ut, out number2))
            {
                Console.WriteLine(number2+ " " + number1);  
            }
            else
            {
                Console.WriteLine("Введено не число");
            }




            
            

        }


    }

}
