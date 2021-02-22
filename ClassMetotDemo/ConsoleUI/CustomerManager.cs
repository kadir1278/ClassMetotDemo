using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Ürün Eklendi");
        }
        public void Delete()
        {
            Console.WriteLine("Ürün Silindi");
        }
        public void Update()
        {
            Console.WriteLine("Ürün Güncellendi");
        }
        public void GetAll()
        {
            string[] Customer = {"Ürün 1","Ürün 2","Ürün 3" };
            foreach (var item in Customer)
            {
                Console.WriteLine(item.ToString());
            }
        }
            
    }
}
