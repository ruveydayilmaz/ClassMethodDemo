using System;

namespace ClassMethodDemo
{
    class Bank
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!\n");

            Customer customer1 = new Customer();
            customer1.Name = "Bessie";
            customer1.LastName = "Liu";
            customer1.Id = 1806;
            customer1.Balance = 5038.8;

            Customer customer2 = new Customer();
            customer2.Name = "Anna";
            customer2.LastName = "Clark";
            customer2.Id = 1807;
            customer2.Balance = 2045.5;

            Customer customer3 = new Customer();
            customer3.Name = "Mylo";
            customer3.LastName = "Frank";
            customer3.Id = 1808;
            customer3.Balance = 3500;

            Customer customer4 = new Customer();
            customer4.Name = "Joann";
            customer4.LastName = "Mill";
            customer4.Id = 1809;
            customer4.Balance = 137.5;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();

            //add all customers
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);
            customerManager.AddCustomer(customer4);
            //add all customers

            //list customers
            customerManager.ListAllCustomers(customers);
            //list customers

            //delete customer
            customerManager.DeleteCustomer(customer2, customers);
            customerManager.DeleteCustomer(customer4, customers);
            //delete customer
        }
    }
}
