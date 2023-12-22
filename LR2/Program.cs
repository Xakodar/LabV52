using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouquet bouquet = new Bouquet();
            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "1. Добавить цветок в букет\n" +
                    "2. Убрать цветок из букета\n" +
                    "3. Поставить букет в воду\n" +
                    "4. Извлечь букет из воды\n" +
                    "5. Стоимость букета\n" +
                    "6. Реальня стоиомость букета\n" +
                    "7. Вывести состояние букета\n" +
                    "8. Количество цветков в букете\n" +
                    "9. Количество завядших цветков\n" +
                    "10. Изменить время букета\n" +
                    "11. Выход");
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Write("Введите название цветка: ");   
                        string name = Console.ReadLine();
                        foreach (var c in Enum.GetValues(typeof(colors)))
                            Console.WriteLine($"{(int)c}. {c.ToString()}");
                        Console.Write("Введите цвет: ");
                        colors color = (colors)Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите скорость увядания в воде ∈ [0; 1]: ");
                        double rateWitheringInWater = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите скорость увядания без воды ∈ [0; 1]: ");
                        double rateWitheringWithoutWater = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите стоимость цветка: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Flower flower = new Flower(name, color, rateWitheringInWater, rateWitheringWithoutWater, price);
                        bouquet.addFlower(flower);
                        break;
                    case 2:
                        Console.Write("Введите id цветка: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        try { bouquet.delFlower(id); }
                        catch (ArgumentException e) { Console.WriteLine(e.Message); }
                        break;
                    case 3:
                        bouquet.setInWater();
                        break;
                    case 4:
                        bouquet.setOutWater();
                        break;
                    case 5:
                        Console.WriteLine($"Стоимость букета: {bouquet.price()}");
                        break;
                    case 6:
                        Console.WriteLine($"Реальная стоимость букета: {bouquet.realPrice()}");
                        break;
                    case 7:
                        bouquet.print();
                        break;
                    case 8:
                        Console.WriteLine($"Количество цветков в букете: {bouquet.flowersCount()}");
                        break;
                    case 9:
                        Console.WriteLine($"Количество завядших цветков в букете: {bouquet.wiltedCount()}");
                        break;
                    case 10:
                        Console.Write("Введите время изменения: ");
                        double t = Convert.ToDouble(Console.ReadLine());
                        bouquet.diffTime(t);
                        break;
                    case 11:
                        return;
                }
            }
        }
    }
}
