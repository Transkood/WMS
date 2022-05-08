using System;

class Input {
    static void Main() {

        Console.WriteLine("Введите массу груза:");
        double weight = Convert.ToDouble(Console.ReadLine())/100;

        Console.WriteLine("Введите ФИО отправителя");
        string name = Console.ReadLine();

        Console.WriteLine("Введите точку прибытия");
        string city = Console.ReadLine();
    }
}
