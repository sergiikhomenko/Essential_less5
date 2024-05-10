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
    private double _costOfGoods;

    public Article(string goodsName, string nameShop, double costOfGoods)
    {
        this._nameShop = nameShop;
        this._productName = goodsName;
        this._costOfGoods = costOfGoods;
    }

    public string GoodsName
    {
        get { return _productName; }
    }

    public void ShowInfoFoGoods()
    {
        Console.WriteLine(_nameShop);
        Console.WriteLine(_productName);
        Console.WriteLine(_costOfGoods);
    }
}