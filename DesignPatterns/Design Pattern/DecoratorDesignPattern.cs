namespace DesignPatterns.Design_Pattern
{
    #region Description
    /*
        The Decorator design pattern is a structural pattern that allows behavior to be added to an object dynamically without
        affecting its original behavior or structure. It is useful when you want to extend the functionality of a class at runtime
        or when it is not feasible to extend the functionality of a class by subclassing.
        In the Decorator pattern, there is a base object (or "component") which defines the basic behavior, and one or
        more decorator classes which add additional behavior to the base object. Each decorator class wraps an instance of
        the base object, adding its own functionality to it. The decorator classes have the same interface as the base object,
        so they can be used interchangeably.
     */
    /*
        Problem/Solution:The decorator design pattern is useful for adding or modifying the behavior of an object at runtime,
        without affecting other objects of the same class. This pattern allows for a flexible and dynamic approach to object composition,
        as new behaviors can be added to an object by wrapping it with one or more decorators, and existing behaviors can be modified
        by replacing or removing decorators. This can be especially useful when working with complex or evolving systems,
        where the behavior of objects may need to be modified or extended without requiring significant changes to the underlying code.
     
     */
    #endregion
    #region Implementation
    public interface IBasePizza
    {
        public int Cost();
    }
    public class FarmHousePizza : IBasePizza
    {
        public int Cost()
        {
            return 100;
        }
    }
    public class VeggyDelightPizza : IBasePizza
    {
        public int Cost()
        {
            return 120;
        }
    }
    public class MargrettaPizza : IBasePizza
    {
        public int Cost()
        {
            return 150;
        }
    }

    public abstract class PizzaToppingsDecorator : IBasePizza
    {
        protected readonly IBasePizza _basePizza;
        protected PizzaToppingsDecorator(IBasePizza basePizza)
        {
            _basePizza = basePizza;
        }
        public virtual int Cost()
        {
            return this._basePizza.Cost();
        }
    }

    public class ExtraCheeseDecorator : PizzaToppingsDecorator
    {
        public ExtraCheeseDecorator(IBasePizza basePizza) : base(basePizza)
        {

        }
        public override int Cost()
        {
            return _basePizza.Cost() + 50;
        }
    }

    public class ExtraPaneerDecorator : PizzaToppingsDecorator
    {
        public ExtraPaneerDecorator(IBasePizza basePizza) : base(basePizza)
        {

        }

        public override int Cost()
        {
            return _basePizza.Cost() + 40;
        }
    }

    public static class DecoratorClient
    {
        public static void Demo()
        {
            IBasePizza myPizza = new FarmHousePizza();
            IBasePizza allToppings = new ExtraPaneerDecorator(new ExtraCheeseDecorator(myPizza));
            Console.WriteLine($"your total bill is {allToppings.Cost()}");
        }

    }
    #endregion
}
