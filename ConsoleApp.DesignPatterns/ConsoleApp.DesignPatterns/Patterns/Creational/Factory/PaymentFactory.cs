using ConsoleApp.DesignPatterns.Patterns.Creational.Factory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Patterns.Creational.Factory;

public class PaymentFactory
{
    public IPaymentService Create(ServicesAvailableEnum serviceToCharge)
    {
        if (serviceToCharge == ServicesAvailableEnum.Italian)
            return new ItalianPaymentService();

        if (serviceToCharge == ServicesAvailableEnum.Brazilian)
            return new BrazilianPaymentService();

        return null;
    }
    public enum ServicesAvailableEnum
    {
        Italian,
        Brazilian
    }
}
