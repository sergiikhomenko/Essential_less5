namespace task3;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити клас MyMatrix, який забезпечує надання матриці довільного
 * розміру з можливістю зміни числа рядків і стовпців. Написати програму, яка
 * виводить на екран матрицю і похідні від неї матриці різних порядків.
 */

class Program
{
    static void Main(string[] args)
    {
        MyMatrix myMatrix = new MyMatrix();
        Console.WriteLine("Початкова матриця");
        
        myMatrix.OutMatrix();
        for (int i = 1; i < Math.Min(myMatrix.SizeArreyX, myMatrix.SizeArreyY); i++)
        {
            Console.WriteLine($"\n Похідна матриця порядку {i}:");
            myMatrix.DerivativeMatrix(i).OutMatrix();
        }
        
    }
}