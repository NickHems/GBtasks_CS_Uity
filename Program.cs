using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region anketa
            ////anketa  (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            ////а) используя склеивание;
            ////б) используя форматированный вывод;
            ////в) используя вывод со знаком $.

            ////name
            //Console.WriteLine("Your name");
            //string personName = Console.ReadLine();

            ////surname
            //Console.WriteLine("Your surname");
            //string personSurName = Console.ReadLine();

            ////age
            //Console.WriteLine("Your age");
            //string personAge = Console.ReadLine();

            ////height
            //Console.WriteLine("Your height in cm");
            //int personHeight = int.Parse(Console.ReadLine());

            ////weight
            //Console.WriteLine("Your weight in kg");
            //string personWeight = Console.ReadLine();

            ////вывод со склеиванием
            //Console.WriteLine("Your name and surname is " + personName + " " + personSurName + ". You are " + personAge + " years old, "
            //    + personHeight + " cm high, and your weight is " + personWeight + " KGs");

            //Console.WriteLine(new string('=', 100));

            ////форматированный вывод
            //Console.WriteLine("Your Name and Surname: {0} {1}. \n you are {2} years old. \n " +
            //    "your height is {3:C} cm, \n and your weight is {4} kgs", personName, personSurName, personAge, personHeight, personWeight);

            //Console.WriteLine(new string('+', 100));

            ////вывод с $
            //Console.WriteLine($"Your Name and Surname: {personName} {personSurName}. \n you are {personAge} years old. \n " +
            //    $"your height is {personHeight} cm, \n and your weight is {personWeight} kgs");
            //Console.WriteLine(new string('$', 100));

            //Console.ReadKey();
            #endregion


            #region IMT
            ////IMT

            ////Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) 
            ////по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.


            //float Weight, Height, IMT;


            //Console.WriteLine("Your weight in KGs");
            //Weight = float.Parse(Console.ReadLine());

            //Console.WriteLine("Your height in meters");
            //Height = float.Parse(Console.ReadLine());

            //IMT = Weight / (Height * Height);

            //Console.WriteLine($"Your body mass index is {IMT} ");


            //Console.ReadKey();


            #endregion

            #region coordinates
            ////Написать программу, которая подсчитывает расстояние между точками с координатами 
            ////x1, y1 и x2,y2 по формуле 
            ////    r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            ////    Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            ////*Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.


            //float lengthBetweenCoordinates(float x1, float x2, float y1, float y2)
            //{
            //    float lentgh = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //    return lentgh;
            //}

            //float length2 = lengthBetweenCoordinates(-3, 7, -3, 4);

            //Console.WriteLine("{0:F}", length2);
            //Console.ReadKey();

            #endregion


            #region valueExchange
            ////Написать программу обмена значениями двух переменных:
            ////а) с использованием третьей переменной;
            ////б) *без использования третьей переменной.

            //int a, b , c;

            //a = 456; b = 77741;

            //Console.WriteLine($"Было а = {a}, b = {b}");

            ////c = b; // с использованием 3й переменной
            ////b = a;
            ////a = c;

            ////a = a + b; // без использования 3й переменной
            ////b = a - b;
            ////a = a - b;

            //a = -a - b; // без использования 3й переменной. вариант 2
            //b = -a - b;
            //a = -a - b;


            //Console.WriteLine($"Стало а = {a}, b = {b}");
            //Console.ReadKey();

            #endregion


            #region name and city
            ////а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            ////б) *Сделать задание, только вывод организовать в центре экрана.
            ////в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).



            //string message = "Имя Фамилия, город проживания";

            //int positionX = (Console.WindowWidth - message.Length) / 2; //вычисление середины экрана по горизонтали
            //int positionY = Console.WindowHeight / 2;                   // по вертикали

            //Console.SetCursorPosition(positionX, positionY);  //высталение курсора в середину консоли
            //Console.WriteLine(message);


            //void PrintMessage(string msg, int posX, int posY)
            //{
            //    Console.SetCursorPosition(posX, posY);
            //    Console.WriteLine(msg);

            //}

            //PrintMessage("hello", 50, 10);

            //Console.ReadKey();

            #endregion

            #region new classes

            //Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

            AdditionalToolsClass.PrintMessage("hello", 50, 10); // Метод в классе AdditionalToolsClass который выводит сообщение в заданном положении на консоли

            AdditionalToolsClass.Delay(); // Метод в классе AdditionalToolsClass который при помощи комманды console.readkey приостанавливает выполнение программы

            #endregion


        }
    }
}
