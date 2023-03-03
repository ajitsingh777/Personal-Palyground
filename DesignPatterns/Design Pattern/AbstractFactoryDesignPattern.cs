
///https://refactoring.guru/design-patterns/abstract-factory
namespace DesignPatterns.Design_Pattern
{
    #region Description
    /*
        The Abstract Factory design pattern is a creational pattern that provides an interface for creating families
        of related or dependent objects without specifying their concrete classes. The pattern consists of the following components:
        Abstract factory: This is an interface that declares the methods for creating the products.
        Concrete factories: These are classes that implement the abstract factory and provide the concrete implementation for creating the products.
        Abstract product: This is an interface that defines the type of product objects that will be created by the abstract factory.
        Concrete products: These are classes that implement the abstract product and define the specific products that will be created by the concrete factories.
    */
    /*
        Problem/Solution:
        The Abstract Factory pattern allows you to create objects that are related to each other, such as objects that belong to
        the same product family. By encapsulating the creation of these objects in the abstract factory, you can simplify the rest
        of your code and make it easier to understand and maintain.
        Another advantage of the Abstract Factory pattern is that it provides a way to encapsulate the logic of object creation
        in one place. This makes it easier to modify the code if you need to change the way objects are created, as you only need
        to modify the concrete factories.
        In addition, the Abstract Factory pattern is useful in situations where you need to create objects that have a
        complex construction process, such as objects that depend on other objects or objects that require parameters to be passed
        to their constructors. By encapsulating the creation of these objects in the abstract factory, you can simplify the rest of
        your code and make it easier to understand and maintain.
     */
    #endregion

    #region Implementation
    public interface IBank
    {
        string BankName();
    }
    public class HdfcBank : IBank
    {
        public string BankName()
        {
            return "HDFC Bank";
        }
    }
    public class AxisBank : IBank
    {
        public string BankName()
        {
            return "Axis Bank";
        }
    }
    public class SbiBank : IBank
    {
        public string BankName()
        {
            return "SBI Bank";
        }
    }

    public abstract class Loan
    {
        protected double rate;
        public abstract void setInteresrRate(double r);

        public void CalculateInterest(double loanAmount, int years)
        {
            double EMI;
            int n;

            n = years * 12;
            rate = rate / 1200;
            EMI = ((rate * Math.Pow((1 + rate), n)) / ((Math.Pow((1 + rate), n)) - 1)) * loanAmount;
            Console.WriteLine($"your monthly EMI is {EMI} for the amount {loanAmount} you have borrowed");
        }
    }
    class HomeLoan : Loan
    {
        public override void setInteresrRate(double r)
        {
            rate = r;
        }
    }

    class BusinessLoan : Loan
    {
        public override void setInteresrRate(double r)
        {
            rate = r;
        }
    }
    class StudyLoan : Loan
    {
        public override void setInteresrRate(double r)
        {
            rate = r;
        }
    }

    public abstract class AbstractFactory
    {
        public abstract IBank GetBank(string bankName);
        public abstract Loan GetLoan(string loanName);
    }

    public class BankFactory : AbstractFactory
    {
        public override IBank GetBank(string bankName)
        {
            if (bankName is null)
            {
                throw new InvalidOperationException("bank name can't be null");
            }
            switch (bankName.ToUpperInvariant())
            {
                case "HDFC":
                    return new HdfcBank();
                case "AXIS":
                    return new HdfcBank();
                case "SBI":
                    return new HdfcBank();
                default:
                    throw new InvalidOperationException("invalid choice");
            }
        }

        public override Loan GetLoan(string loanName)
        {
            throw new NotImplementedException();
        }
    }

    public class LoanFactory : AbstractFactory
    {
        public override IBank GetBank(string bankName)
        {
            throw new NotImplementedException();
        }

        public override Loan GetLoan(string loanName)
        {
            if (loanName is null)
            {
                throw new InvalidOperationException("loan can't be null or empty");
            }
            switch (loanName.ToUpperInvariant())
            {
                case "HOME":
                    return new HomeLoan();
                case "BUSINESS":
                    return new BusinessLoan();
                case "EDUCATION":
                    return new StudyLoan();
                default:
                    throw new InvalidOperationException("Invalid choice");
            }
        }
        
        public static class FactoryCreator
        {
            public static AbstractFactory GetFactory(string choice)
            {
                if (choice.Equals("Bank", StringComparison.InvariantCultureIgnoreCase))
                {
                    return new BankFactory();
                }
                else if (choice.Equals("Loan", StringComparison.InvariantCultureIgnoreCase))
                {
                    return new LoanFactory();
                }
                return null;
            }
        }

        public class AbstractFactoryClient
        {
            public void Demo()
            {
                AbstractFactory bankFactory = FactoryCreator.GetFactory("Bank");
                IBank bank = bankFactory.GetBank("HDFC");
                AbstractFactory loanFactory = FactoryCreator.GetFactory("Loan");
                Loan loan = loanFactory.GetLoan("HOME");
                Console.WriteLine($"your bank name is {bank.BankName()}");
                loan.setInteresrRate(10);
                loan.CalculateInterest(10000, 5);
            }
        }
    }
    #endregion

}
