namespace task4;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно:
 * Створити клас Article, що містить наступні закриті поля:
   • Назва товару;
   • назва магазину, в якому продається товар;
   • вартість товару в гривнях. 
   Створити клас Store, який містить закритий масив елементів типу Article.
   Забезпечити такі можливості:
   • висновок інформації про товар за номером за допомогою індексу;
   • висновок на екран інформації про товар, назва якого введено з клавіатури, 
   якщо таких товарів немає, видати відповідне повідомлення.
   Написати програму, виведення на екран інформацію про товар.
 */
public class Article
{
    private string _productName;
    private string _nameShop;
    private double _costOfGood;

    public string ProductName
    {
        set { _productName = value;}
        get { return _productName;}
    }

    public string NameShop
    {
        set { _nameShop = value; }
        get { return _nameShop; }
    }

    public double CostOfGood
    {
        set { _costOfGood = value; }
        get { return _costOfGood; }
    }
}