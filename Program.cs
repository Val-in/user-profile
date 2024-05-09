using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace user_profile
{
    internal class Program
    {
        static void Main(string[] args) //тут круглые скобки
        {
            // Программа. Требуется сохранять информацию: об имени пользователя, фамилии, логине, длине логина, наличии/отсутствии у пользователя питомца,
            // возрасте пользователя, трех любимых цветах пользователя.

            for ( int k = 0; k < 3; k++)
            { 
            (string name, string surname, string login, int loginLength, bool pet, int age, string[] favoritecolor) info; // string[] favoritecolor, забыла [], это массив
            Console.WriteLine("Введите имя");
                info.name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
                info.surname = Console.ReadLine();

            Console.WriteLine("Введите логин");
               info.login = Console.ReadLine(); //забыла присвоить переменные, указала только Console.ReadLine();

            info.loginLength = info.login.Length; //эта команда вычисляет длину логина 

            Console.WriteLine("Есть ли у вас животные? Да или Нет");

            var result = Console.ReadLine(); // сначала нужно было добавить переменную
            if (result == "Да")
                    {
               info.pet = true;
        }
            else
            {
                info.pet = false;
            }

            Console.WriteLine("Введите возраст пользователя");
            info.age = Convert.ToInt32(Console.ReadLine()); // или можно info.age = int.Parse(Console.ReadLine());

            string[] favoritecolor = new string[3];

            Console.WriteLine("Введите три любимых цвета пользователя");
            for (int i = 0; i < 3; i++)
            {
                favoritecolor [i] = Console.ReadLine();
                
                    Console.WriteLine((i + 1) + ". " + favoritecolor [i]); //мы используем (i + 1), чтобы скорректировать порядковый номер

            }
                  
}
    }
}
}