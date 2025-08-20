using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1,"Note",50);
            Product product2 = new Product(2, "Eraser", 5);
            Product product3 = new Product(3, "Scale", 25);
            Product product4 = new Product(4, "Pencil", 10);
            ShoppingCart cart = new ShoppingCart();

            Console.WriteLine(product1);
            Console.WriteLine(product2);

            cart.AddProduct(product1);
            cart.AddProduct(product3);
            cart.AddProduct(product2);
            cart.AddProduct(product3);
            cart.AddProduct(product4);
            cart.AddProduct(product3);

            cart.RemoveProduct(product3);

            cart.CalculateTotal();
           
            cart.DisplayCart();

            Console.ReadLine();

        }
    }

    class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(int Id,string Name,double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Product other = (Product)obj;
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"Id: {Id},Name: {Name},Price: {Price}";
        }
        
    }

    class ShoppingCart
    { 
        private Dictionary<Product, int> CartItems = new Dictionary<Product, int>();

        public void AddProduct(Product p)
        {
            if (CartItems.ContainsKey(p))
            {
                CartItems[p]++;
            }
            else
            {
                CartItems[p] = 1;
            }
            Console.WriteLine($"{p.Name} added to cart");
        }

        public void RemoveProduct(Product p)
        {
            if (CartItems.ContainsKey(p))
            {
                CartItems[p]--;
                if(CartItems[p] <= 0)
                {
                    CartItems.Remove(p);
                }
                Console.WriteLine($"{p.Name} removed from cart!");
            }
            else
            {
                Console.WriteLine("Product not found in Cart");
            }
            
        }

        public void CalculateTotal()
        {
            double TotalAmount = CartItems.Sum(p => p.Value * p.Key.Price);
            Console.WriteLine($"Total Cart Amount: {TotalAmount}");
        }

        public void DisplayCart()
        {
            if(CartItems.Count == 0)
            {
                Console.WriteLine("Cart is empty!");
            }
            else
            {
                Console.WriteLine("Products in Cart:");
                foreach(var item in CartItems)
                {
                    Console.WriteLine($"{item.Key.Name} - Quantity - {item.Value} - {item.Key.Price}/pcs - Total Amount - {item.Key.Price * item.Value}");
                }
            }
        }
    }
}
