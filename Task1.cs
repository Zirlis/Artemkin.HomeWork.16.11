using System;
using System.Text.RegularExpressions;

class Task1
{
    //1. Создать программу, которая будет проверять корректность ввода логина.
    //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    //а) без использования регулярных выражений;
    //б) с использованием регулярных выражений.

    //Часть А
    internal void Task1A()
    {
        bool check;
        do
        {
            check = false;
            Console.WriteLine($"Введите логин");

            string login = Console.ReadLine();
            char[] c = login.ToCharArray();

            if(login.Length < 2 || login.Length > 10)
            {
                Console.WriteLine($"Длина логина должна быть от двух до десяти символов");
                check = true;
            }
            if(c[0] >= 0 && c[0] <= 9)
            {
                Console.WriteLine($"Первый символ не может быть цифрой");
                check = true;
            }
            foreach (char symbol in c)
            {
                if (!(symbol >= 'A' && symbol <= 'Z') && !(symbol >= 'a' && symbol <= 'z') && !char.IsNumber(symbol))
                {
                    Console.WriteLine($"Логин должен содержать только буквы английского алфавита и цифры");
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                Console.WriteLine($"Логин принят");
            }
            Console.ReadKey();
            Console.Clear();
        } while (check);
    }

    //Часть Б
    internal void Task1B()
    {
        bool check;
        Regex regex = new Regex("^[^0-9]([a-z]|[A-Z]|[0-9]){1,9}$");
        do
        {
            Console.WriteLine($"Введите логин");
            check = regex.IsMatch(Console.ReadLine());

            if(check)
            {
                Console.WriteLine($"Логин принят");
            }
            else
            {
                Console.WriteLine($"Недопустимый логин");
                Console.WriteLine($"Длина логина должна быть от двух до десяти символов");
                Console.WriteLine($"Первый символ не может быть цифрой");
                Console.WriteLine($"Логин должен содержать только буквы английского алфавита и цифры");
            }

            Console.ReadKey();
            Console.Clear();
        } while (!check);
    }
}
