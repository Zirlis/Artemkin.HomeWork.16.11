using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Task2
{
    //2. Разработать класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения, которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //Продемонстрируйте работу программы на текстовом файле с вашей программой.

    internal void Message()
    {       
        StreamReader sr = new StreamReader("text.txt");
        string text = sr.ReadToEnd();
        string[] words = text.Split(' ', '.', ',', '!', '?', '-');

        //Часть А        
        Console.WriteLine($"Введите максимальную длину слов");
        int n = Int32.Parse(Console.ReadLine());
        foreach(string word in words)
        {
            if(word.Length <= n && word != " ")
            {
                Console.Write($"{word} ");
            }            
        }
        Console.WriteLine();
        Console.WriteLine();

        //Часть Б
        Console.WriteLine($"Введите символ на который не должны заканчиваться слова");
        char ignorSymbol = Char.Parse(Console.ReadLine());
        foreach (string word in words)
        {
            char[] symbols = word.ToCharArray();
            if(symbols.Length != 0 && symbols[word.Length - 1] != ignorSymbol)
            {
                Console.Write($"{word} ");
            }            
        }
        Console.WriteLine();
        Console.WriteLine();

        //Часть В и Г
        Console.WriteLine($"Самые длинные слова в предложении:");
        int maxLength = 0;
        List<string> maxLengthWord = new List<string>();
        foreach (string word in words)
        {
            if(word.Length > maxLength)
            {
                maxLength = word.Length;                
            }
        }

        foreach (string word in words)
        {
            if (word.Length == maxLength)
            {
                maxLengthWord.Add(word);
            }
        }

        if (maxLength == 0)
        {
            Console.WriteLine($"Текст не найден");
        }
        else
        {
            foreach(string word in maxLengthWord)
            {
                Console.Write($"{word} ");
            }
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}
