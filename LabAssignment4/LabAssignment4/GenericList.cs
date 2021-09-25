using System;

namespace LabAssignment4
{
    class ProductList
    {
        static void Main()
        {
            Product product1 = new Product { ProductName = "Strawberry", ProductCode = 1, Category = "Ice-Cream" };
            Product product2 = new Product { ProductName = "Mango", ProductCode = 2, Category = "Ice-Cream" };

            List<product> ProductList = new List<Product>();
            ProductList.Add(product1);
            ProductList.Add(product2);

            foreach (var pro in ProductList)
            {
                Console.WriteLine("{0}\t{1}\t{2}", pro.ProductName, pro.ProductCode, pro.Category);
            }
            Console.ReadLine();
        }
    }
}
