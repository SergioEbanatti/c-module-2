using System;

namespace Module_2
{
    internal class Program
    {
        static void Main()
        {
            string fullName = " Иванов Иван Иванович";
            int age = 20;
            string email = "ivanov@yandex.ru";
            float iTScore = 80;
            float mathScore = 65;
            float physicsScore = 69;

            float totalScore = iTScore + mathScore + physicsScore;
            float gPA = totalScore / 3;



            Console.WriteLine($"Ф.И.О.: {fullName} \nВозраст: {age} \nEmail: {email} \nБаллы по программированию: {iTScore} \nБаллы по математике: {mathScore} \nБаллы по физике: {physicsScore} \n\nЧтобы узнать баллы, нажмите любую клавишу");
            Console.ReadKey(true);
            Console.WriteLine($"\nСумма баллов: {totalScore} \nСредний балл: {(float)Math.Round(gPA, 2)}");
            Console.ReadLine();
        }

    }
}
