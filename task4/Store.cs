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
public class Store
{
    private Article[] _goodsOfStor;

    public Store(params Article[] article)
    {
        _goodsOfStor = article;
    }
    
    public Article this[int indexGood]
    {
        get
        {
            return _goodsOfStor[indexGood];
        }
    }

    public void SearchGoodsForName(string nameGoods)
    {
        bool res = false;
        for (int   i = 0;   i < _goodsOfStor.Length;   i++)
        {
            if (_goodsOfStor[i].GoodsName == nameGoods)
            {
                res = true;
                _goodsOfStor[i].ShowInfoFoGoods();
            }
        }
        if (!res)
        {
            Console.WriteLine("За  вашим запитом нічого не знайдено");
        }
        
    }
}