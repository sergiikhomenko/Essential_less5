using System.Threading.Channels;

namespace task2;

/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити масив розмірністю N елементів, заповнити його довільними цілими
 * значеннями. Вивести найбільше значення масиву, найменше значення масиву, загальну
 * суму елементів, середнє арифметичне всіх елементів, вивести всі непарні значення.
 */
class Program
{
    static void Main(string[] args)
    {
        int arreySize;
        Random rd = new Random();
        arreySize = rd.Next(1, 30);
        
        int[] arrey = new int[arreySize];
        
        for (int i = 0; i < arrey.Length; i++)
        {
            arrey[i] = rd.Next(1, 30);
        }

        Console.Write("Непарні елемнти масиву ");
        for (int i = 0; i < arrey.Length; i++)
        {
            if (arrey[i] % 2 != 0)
            {
                Console.Write($" {arrey[i]}");
            }
        }

        Console.WriteLine();

        Console.WriteLine($"Максимальний елемент {arrey.Max()}");
        Console.WriteLine($"Мінімальний елемент {arrey.Min()}");
        Console.WriteLine($"Сума  елементів {arrey.Sum()}");
        Console.WriteLine($"Середнє {arrey.Average()}");

      
    }
}