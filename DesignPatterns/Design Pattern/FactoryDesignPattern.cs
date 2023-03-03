
namespace DesignPatterns.Design_Pattern
{
    #region Description
    /* 
        The Factory Method pattern suggests that you replace direct object construction calls (using the "new" operator)
        with calls to a special factory method. The factory method then returns the newly created object. The pattern is
        useful in situations where a class cannot anticipate the type of objects it needs to create or it needs to delegate
        the responsibility of object creation to its subclasses.

        Problem/Solution:
            
        The Factory Method design pattern solves the problem of object creation in a flexible and maintainable way. 
        The pattern is especially useful in situations where:
        A class cannot anticipate the type of objects it needs to create. For example, a class that needs to create objects
        based on user input.
        A class wants to delegate the responsibility of object creation to its subclasses. This allows subclasses to choose 
        the type of objects to be created, or to provide their own implementation of object creation.

        You want to encapsulate the logic of object creation in one place. This makes it easier to maintain and modify the code,
        as you only need to change the factory method if you want to change the way objects are created.
        You need to create objects that have a complex construction process. By encapsulating the creation of these objects in
        the factory method, you can simplify the rest of your code and make it easier to understand and maintain.
        The Factory Method pattern provides a solution to these problems by allowing you to separate the creation of
        objects from their use. This makes your code more flexible and maintainable, as you can change the type of objects
        created by the factory method without affecting the rest of your code.

     */

    #endregion

    #region Implementation
    public interface INotification
    {
        public void Notify(string message);
    }

    public class EmailNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Email notification sent with message: {message}");
        }
    }

    public class SmsNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS notification sent with message: {message}");
        }
    }

    public class PushNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Push notification sent with message: {message}");
        }
    }

    public static class NotificationFactory
    {
        public static INotification GetNotificationInstance(string type)
        {
            switch (type.ToUpper())
            {
                case "EMAIL":
                    return new EmailNotification();
                case "SMS":
                    return new SmsNotification();
                case "PUSH":
                    return new PushNotification();
                default:
                    throw new InvalidOperationException("No such type of notification exist");
            }
        }
    }

    public class NotificationClient
    {
        public void SendNotification(string type, string message = "")
        {

            INotification notification = NotificationFactory.GetNotificationInstance(type);
            notification.Notify(message);
        }
    }
    #endregion
}
