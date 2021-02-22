using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }


}
