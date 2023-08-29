using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public string Company { get; set; }
    }

    public class ProductCRUD
    {
        private List<Product> productlist;
        public ProductCRUD()
        {
            productlist = new List<Product>()
            {
                new Product { Id = 101, Name = "Laptop", Price = 50000, Company = "Dell" },
                new Product { Id = 102, Name = "Laptop", Price = 137000, Company = "MacBook" }

            };
        }
        public List<Product> GetProduct()
        {
            return productlist;

        }
        public Product GetProductById(int id)
        {
            Product product = new Product();
            foreach (Product p in productlist)
            {
                if (p.Id == id)
                {
                    product = p;
                    break;
                }
            }
            return product;
        }
        public void AddProduct(Product p)
        {
            productlist.Add(p);
        }
        public void UpdateProduct(Product p)
        {
            foreach (Product item in productlist)
            {
                if (item.Id == p.Id)
                {
                    item.Price = p.Price;
                    item.Company = p.Company;
                    item.Name = p.Name;
                    break;
                }
            }
        }
        public void DeleteProduct(int id)
        {
            foreach (Product item in productlist)
            {
                if (item.Id == id)
                {
                    productlist.Remove(item);
                    break;
                }
            }
        }



    }
}

    

