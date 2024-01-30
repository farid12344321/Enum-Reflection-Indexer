
using Homework_Enum_Reflection;
using System.Reflection;

count:
Console.WriteLine("Product arrayin uzunluqunu daxil edin");
string countStr = Console.ReadLine();
int count;
if(!int.TryParse(countStr,out count))
{
    goto count;
}

Product[] product = new Product[count];
for (int i = 0; i < product.Length; i++)
{
    Console.WriteLine("Name daxil edin:");
    string nameStr = Console.ReadLine();

    string priceStr;
    double price;
    do
    {
        Console.WriteLine("Price daxil edin:");
        priceStr = Console.ReadLine();
    } while (!double.TryParse(priceStr,out price));


    string typeStr;
    byte type;
    do
    {
        Console.WriteLine("Type daxil edin:\n 1 - Baker\n 2 - Drink\n 3 - Meat\n 4 - Diary");
        typeStr = Console.ReadLine();

    } while (!byte.TryParse(typeStr,out type) || !Enum.IsDefined(typeof(ProductType),type));
   


    Product product2 = new Product()
    {
        Name = nameStr,
        Price = price,
        Type = (ProductType)type
    };
    product[i] = product2;

}
for (int i = 0; i < product.Length; i++)
{
    Console.WriteLine(product[i]);
}

//Reflection taskı üçün icə dərsdə danışdığımız kimi object array qebul edib içində _salary field olan obyektlərin Salarylərinin cəmini tapıb qaytaran metod yazırsınız.
double CalculateTotalSalaries(object[] objects)
 {
    double totalSalary = 0;
    foreach (var obj in objects)
    {
        var type = obj.GetType();
        var field = type.GetField("_salary", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        if (field != null)
        {
            double salary = (double)field.GetValue(obj);
            totalSalary += salary;
        }
    }
    return totalSalary;
 }
