using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
           customerManager.Save(new Customer { NationalityId = "T.C", DateOfBirth = new DateTime("Doğum Tarihi"), FirstName = "Ad",  LastName = "Soyad"});
            Console.ReadLine();

           
        }

    }
}
