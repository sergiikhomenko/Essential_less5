using System.Threading.Channels;

namespace task4;

/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити клас Article, що містить наступні закриті поля:
   • Назва товару;
   • назва магазину, в якому продається товар;
   • вартість товару в гривнях. Створити клас Store, який містить закритий масив елементів типу Article.
   Забезпечити такі можливості:
   • висновок інформації про товар за номером за допомогою індексу;
   • висновок на екран інформації про товар, назва якого введено з клавіатури, якщо таких товарів немає,
    видати відповідне повідомлення.
   Написати програму, виведення на екран інформацію про товар.
 */
class Program
{
    static void Main(string[] args)
    {
        //Store store = new Store();
        while (true)
        {

            Console.WriteLine("Скільки товарів ви бажаєте додати");
            Int32.TryParse(Console.ReadLine(), out int size);
            
            
            Store store = new Store();
            store = new Store(GoodsInShop(size));
            
            Console.WriteLine("Введіть індекс потрібного товару");
            Int32.TryParse(Console.ReadLine(), out int index);
            store[index].ShowInfoFoGoods();
            Console.WriteLine();
            
            Console.WriteLine("Введіть назву товару для пошуку");
            Console.WriteLine();
            store.SearchGoodsForName(Console.ReadLine());
        

        }
    }
    

    public static Article[] GoodsInShop(int sizeOfArreyGoods)
{
    Article[] goodsInShop = new Article[sizeOfArreyGoods];
    for (int i = 0; i < goodsInShop.Length; i++)
    {
        Console.WriteLine("Введіть назву магазинк");
        string shop = Console.ReadLine();

        Console.WriteLine("Введіть назву товару");
        string goodsName = Console.ReadLine();

        Console.WriteLine("Введіть ціну товару");
        Double.TryParse(Console.ReadLine(), out double price);
        Console.WriteLine(new string('*', 30));

        Article goods = new Article(goodsName, shop, price);
        goodsInShop[i] = goods;

        Console.WriteLine();
    }

    return goodsInShop;
}

}