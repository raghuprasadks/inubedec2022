using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharptutorial
{

    internal class Product
    {
        public int code { get; set; }

        public string name { get; set; }
        public string desc { get; set; }
        public string supplier { get; set; }
        public int price { get; set; }
        public Product() { }

        public Product(int code, string name, string desc, string supplier, int price)
        {
            this.code = code;
            this.name = name;
            this.desc = desc;
            this.supplier = supplier;
            this.price = price;
        }

        public string info()
        {
            return $"Code : {this.code} Name : {this.name} Description : {this.desc} Sullier : {this.supplier} Price : {this.price}";
        }

    }
    internal class eSupplier
    {

        List<Product> productList = new List<Product> ();

        /**
         * adds product to the productlist
         */
        public void addProduct()
        {
            Console.WriteLine("Enter the Number of Products to add");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Product code");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Product name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Desc");
                string desc = Console.ReadLine();

                Console.WriteLine("Enter the Supplier name");
                string supplier = Console.ReadLine();

                Console.WriteLine("Enter the Price");
                int price = Convert.ToInt32(Console.ReadLine());
                Product product = new Product(code, name, desc, supplier, price);

                productList.Add(product);
            }
        }
         
            
        public void displayProducts()
        {
            foreach(Product product in productList)
            {
                Console.WriteLine(product.info());
            }
        }


        public void productsBySupplier(string supplier)
        {
            foreach (Product product in productList)
            {
                if (product.supplier.Contains(supplier))
                    Console.WriteLine(product.info());
            }
        }

        public void updateProduct(int code)
        {
            Console.WriteLine("Enter the Price to update");
            int price = Convert.ToInt32(Console.ReadLine());

            foreach (Product product in productList)
            {
                if (product.code == code)
                    product.price = price;
                    
            }
        }

        public void deleteProduct(Product prdtodel)
        {
            productList.Remove(prdtodel);
        }

        public void testSupplier()
        {
            addProduct();
            displayProducts();
            Console.WriteLine("Enter the Supplier name");
            string supplier = Console.ReadLine();
            productsBySupplier(supplier);
            Console.WriteLine("Update: Enter the Product code");
            int code = Convert.ToInt32(Console.ReadLine());

            updateProduct(code);
            Console.WriteLine("After update");
            displayProducts();
            Console.WriteLine("Delete: Enter the Product code");
            int codetodel = Convert.ToInt32(Console.ReadLine());
            int prodindextodel=-1;
            for (int i=0;i< productList.Count;i++)
            {
                if (productList[i].code ==codetodel)
                {
                    prodindextodel=i;

                } 
            }
            //productList.RemoveAt(prodindextodel);
            Product prod = productList[prodindextodel];
            deleteProduct(prod);

            Console.WriteLine("After delete: display products");
            displayProducts();



        }
    }
}
