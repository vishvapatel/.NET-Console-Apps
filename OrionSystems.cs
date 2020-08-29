/*
 * Author: Vishva Patel
 * Problem : TCSXPLORE_OPA 26th June 2020
 * Orion Systems Problem
 */
using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager();

            //Adding Some data to start with
            manager.AddProduct("Mobile Phone", "Goods", 100, 10999);
            manager.AddProduct("Television", "Goods", 50, 30999);
            manager.AddProduct("Customer Relations", "Services", 0, 50000); //As in services there is no quantity. 
            manager.AddProduct("Backup & Restore", "Services", 0, 20943);
            manager.AddProduct("Laptops", "Goods", 200, 25999);

            sbyte choice = Convert.ToSByte(Console.ReadLine());
            //This is where the real program begins as the above code was prewritten.
                
            switch (choice)
            {
                case 1:
                    //Add Product Case
                    string Name = Console.ReadLine();
                    string category = Console.ReadLine();
                    double unitPrice = Convert.ToDouble(Console.ReadLine());
                    if (category == "Goods")
                    {
                        int Quantity = Convert.ToInt32(Console.ReadLine());
                        int Id = manager.AddProduct(Name, category, Quantity, unitPrice);
                        if (Id == 0)
                        {
                            Console.WriteLine($"Product already exist, cannot add again");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"The Product {Name} has been added with the product id {Id}");
                        }
                    }
                    else if (category == "Services")
                    {
                        //Services do not include the attribute quantity so we do not take anything from user.
                        int Id = manager.AddProduct(Name, category, 0, unitPrice);
                        if (Id == 0)
                        {
                            Console.WriteLine($"Product already exist, cannot add again");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"The Product {Name} has been added with the product id {Id}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Category");
                    }
                    break;

                case 2:
                    //Updating the product
                    int Id1 = Convert.ToInt32(Console.ReadLine());
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    double uPrice = Convert.ToDouble(Console.ReadLine());
                    Product pd;
                    pd = manager.UpdateProduct(Id1, quantity, uPrice);
                    if (pd == null)
                    {
                        Console.WriteLine("Prduct does not exist, cannot modify");
                    }
                    else
                    {
                        Console.WriteLine($"Product {pd.ProductName} has been updates with quantity {pd.Quantity} and unit price of {pd.unitPrice}");
                    }
                    break;

                case 3:
                    //Viewing the Products
                    string cat = Console.ReadLine();
                    double totalprice;
                    int goodstax = 12, servicestax = 10;
                    bool goodsflag = false, servicesflag = false;
                    List<Product> productlist = new List<Product>();
                    if (cat == "Goods" || cat == "Services")
                    {
                        productlist = manager.ViewProducts(cat);
                        //Printing for Goods
                        if (cat == "Goods")
                        {
                            foreach (Product p in productlist)
                            {
                                goodsflag = true;
                                //tax = 12% for good category
                                totalprice = p.unitPrice + 0.12 * p.unitPrice;
                                Console.WriteLine($"Category: {p.ProductCategory}, Tax: {goodstax}%");
                                Console.WriteLine($"{p.ProductId}, {p.ProductName}: {p.Quantity} left, unit price: {p.unitPrice}, total price: {totalprice} ");
                            }
                            if (goodsflag == false)
                            {
                                Console.WriteLine("No Products found");
                            }
                        }
                        //Printing for Services
                        if (cat == "Services")
                        {
                            foreach (Product p in productlist)
                            {
                                servicesflag = true;
                                //tax = 12% for good category
                                totalprice = p.unitPrice + 0.10 * p.unitPrice;
                                Console.WriteLine($"Category: {p.ProductCategory}, Tax: {servicestax}%");
                                Console.WriteLine($"{p.ProductId}, {p.ProductName}: unit price: {p.unitPrice}, total price: {totalprice} ");
                            }
                            if (servicesflag == false)
                            {
                                Console.WriteLine("No Products Found");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Category");
                    }
                    break;

                case 4:
                    //Getting the statistcs of the products.
                    Dictionary<string, int> GroupedProducts = new Dictionary<string, int>();
                    GroupedProducts = manager.Statistics();
                    bool goodflag = false, serviceflag = false;
                    foreach (var d in GroupedProducts)
                    {
                        if (d.Key == "Goods")
                        {
                            goodflag = true;
                            Console.WriteLine($"Category: {d.Key}, products: {d.Value}");
                        }
                        if (d.Key == "Services")
                        {
                            serviceflag = true;
                            Console.WriteLine($"Category: {d.Key}, products: {d.Value}");
                        }
                    }
                    if (goodflag == false)
                    {
                        Console.WriteLine("No Products found");
                    }
                    if (serviceflag == false)
                    {
                        Console.WriteLine("No Products Found");
                    }
                    break;
            }
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int Quantity { get; set; }
        public double unitPrice { get; set; }
        public double tax { get; set; }
        public double totalPrice { get; set; } //unitPrice + Tax

        public Product(int Id, string pnm, string cat, int q, double up)
        {
            ProductId = Id;
            ProductName = pnm;
            ProductCategory = cat;
            Quantity = q;
            unitPrice = up;
        }
    }

    class ProductManager
    {
        private List<Product> Products = new List<Product>();
        private static int ProductId = -1;
        private Product updatedProduct;

        public int AddProduct(string pnm, string cat, int q, double up)
        {
            ProductId++;
            Product p = new Product(ProductId, pnm, cat, q, up);
            if (Products.Contains(p))
            {
                ProductId--;
                return 0;
            }
            else
            {
                Products.Add(p);
                return ProductId;
            }
        }
        //Updating the product in the product list
        public Product UpdateProduct(int id, int q,double up)
        {
            bool flag = false;
            foreach(Product p in Products)
            {
                if(p.ProductId == id)
                {
                    if (p.ProductCategory == "Services")
                    {
                        p.unitPrice = up;
                        updatedProduct = p;
                        flag = true;
                        break;
                    }
                    else
                    {
                        p.Quantity = q;
                        p.unitPrice = up;
                        updatedProduct = p;
                        flag = true;
                        break;

                    }
                }
            }
            if (flag == false)
            {
                return updatedProduct = null;
            }
            else
            {
                return updatedProduct;
            }
        }

        //View based on category

        public List<Product> ViewProducts(string cat)
        {
            List<Product> Categoryproduct = new List<Product>();
            foreach(Product p in Products)
            {
                if(p.ProductCategory == cat)
                {
                    Categoryproduct.Add(p);
                }
            }
            return Categoryproduct;
        }

        //Statistics of Products
        public Dictionary<string, int> Statistics()
        {
            Dictionary<string, int> stats = new Dictionary<string, int>();
            foreach(Product p in Products)
            {
                if (stats.ContainsKey(p.ProductCategory))
                {
                    stats[p.ProductCategory] += 1;
                }
                else
                {
                    stats.Add(p.ProductCategory, 1);
                }
            }
            return stats;
        }
    }


}