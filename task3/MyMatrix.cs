namespace task3;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити клас MyMatrix, який забезпечує надання матриці довільного
 * розміру з можливістю зміни числа рядків і стовпців. Написати програму, яка
 * виводить на екран матрицю і похідні від неї матриці різних порядків.
 */
public class MyMatrix
{
    private int _sizeArreyX,_sizeArreyY;
    private int[,] _arrey;

    public int SizeArreyX
    {
        get { return _sizeArreyX; }
    }

    public int SizeArreyY
    {
        get { return _sizeArreyY; }
    }

    public MyMatrix()
    {
        Random rd = new Random();
        _sizeArreyX = rd.Next(1, 30);
        _sizeArreyY = rd.Next(1, 30);
        _arrey = new int[_sizeArreyX, _sizeArreyY];
        AddValueToArreyRandom();
    }

    public MyMatrix(int sizeArreyX, int sizeArreyY)
    {
        _arrey = new int[sizeArreyX, sizeArreyY];
    }

    private void AddValueToArreyRandom()
    {
        Random rd = new Random();
        for (int  i = 0;  i < _arrey.GetLength(0);  i++)
        {
            for (int j = 0; j < _arrey.GetLength(1); j++)
            {
                _arrey[i,j] = rd.Next(1, 100);
            }
        }
    }

    private  void AddValueArrey(int i, int j, int value)
    {
        _arrey[i, j] = value;
    }

    public void OutMatrix()
    {
        Console.WriteLine($" Матриця розміром {_sizeArreyX}, {_sizeArreyY}");
        for (int i = 0; i < _arrey.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < _arrey.GetLength(1); j++)
            {
                Console.Write($" {_arrey[i,j]}");
            }
        }
    }

    public MyMatrix DerivativeMatrix( int order)
    {
        if (order <= 0)
        {
            throw new ArgumentException("Число повинно бути позитивним");
        }

        if (order >= Math.Min(_sizeArreyX, _sizeArreyY))
        {
            throw new ArgumentException("Число не повинно перевищювати Розмір матриці");
        }
        

        MyMatrix derivative = new MyMatrix(_sizeArreyX - order, _sizeArreyY - order);

        for (int i = 0; i < _sizeArreyX - order; i++)
        {
            for (int j = 0; j < _sizeArreyY - order; j++)
            {
               derivative.AddValueArrey(i,j,_arrey[i,j]);
            }
        }

        return derivative;
    }

}