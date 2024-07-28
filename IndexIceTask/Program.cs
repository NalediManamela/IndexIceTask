namespace IndexIceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Products product = new Products(1, "Laptop", "Electronics", 999.99, 10);
            product[2] = "Laptop";
            Console.WriteLine(product[0]);
            Console.WriteLine(product[1]);
            Console.WriteLine(product[2]);
            Console.WriteLine(product[3]);
            product["Price"] = 80222.00;
            product["Stock"] = 10;
            Console.WriteLine("Product ID :" + product["productId"]);
            Console.WriteLine("Product Name:" + product["productName"]);
            Console.WriteLine("Category:" + product["category"]);
            Console.WriteLine("Price" + product["price"]);
            Console.WriteLine("Stock:" + product["stock"]);
        }
    }
}
