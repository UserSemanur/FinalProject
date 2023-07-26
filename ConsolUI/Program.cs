using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsolUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
           //CategoryTest();

            Console.ReadLine();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {

                Console.WriteLine(category.CategoryName);

            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.getProductDetails();

            if (result.Success==true )
            {

                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
        }
    }
}
