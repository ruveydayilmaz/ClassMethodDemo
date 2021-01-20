using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Added {0} {1} to customer list", customer.Name, customer.LastName);
        }

        public int deletedId;
        public void DeleteCustomer(Customer customer, Customer[] customers)
        {
            Console.WriteLine("\nDeleted {0} {1} from customer list", customer.Name, customer.LastName);
            deletedId = customer.Id;
            Console.WriteLine("list of the current customers :\n");
            ListAllCustomers(customers);
        }

        public void ListAllCustomers(Customer[] customers)
        {
            int i = 0;

            Console.WriteLine("\n   \tCustomer List");
            Console.WriteLine(" \t-------------\n");
            Console.WriteLine("CUSTOMER NAME    ID     BALANCE\n");

            foreach (var customer in customers)
            {
                if (customer.Id != deletedId)
                {
                    customers[i] = customer;
                    Console.WriteLine(customer.Name + " " + customer.LastName + "\t" + customer.Id + "\t" + customer.Balance + "\n");
                    i++;
                }
            }
        }
    }
}
