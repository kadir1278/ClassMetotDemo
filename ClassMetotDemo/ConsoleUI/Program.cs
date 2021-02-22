using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager _customer = new CustomerManager();
            _customer.GetAll();
            _customer.Add();
            _customer.Delete();
            _customer.Update();
        }
    }
}
