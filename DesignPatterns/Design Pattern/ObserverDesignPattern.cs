using System;
using System.Collections.Generic;
namespace DesignPatterns.Design_Pattern
{
    #region Description
    /*
        Observer design pattern is a behavioral pattern that defines a one-to-many relationship 
        between objects such that when one object changes state, all of its dependants are notified and 
        updated automatically. In other words, it allows objects to observe and react to changes in other objects.
     */

    /*
        Problem/Solution: The observer design pattern solves the problem of how to keep multiple objects in sync with
        each other when one or more of the objects change their state. Without the observer pattern, it would be difficult
        to manage updates between objects in a clean and maintainable way. For example, consider a scenario where a
        stock price update causes an update in the portfolio value of an investor. Without the observer pattern,
        the investor's portfolio class would need to constantly poll the stock price to see if it has changed,
        which is not only inefficient but also unscalable as the number of stocks in the portfolio increases.

        The observer design pattern solves this problem by allowing objects to "observe" changes
        in other objects and respond accordingly. When the stock price changes, it notifies the investor's portfolio,
        which can then update its value. This way, the portfolio can be updated as soon as the stock price changes,
        without having to constantly poll for updates.

        In this way, the observer pattern provides a flexible, decoupled way of managing updates between objects,
        making it easier to add or remove objects from the system, and making the system more scalable and maintainable.
       
     */

    #endregion

    #region Implementation

    public interface IObserver
    {
        public void Update();
    }
    public interface ISubject
    {
        public void Add(IObserver observer);
        public void Remove(IObserver observer);
        public void Notify();
        public int GetState();
        public void SetState(int state);
    }

    public class TemperatureObserver : IObserver
    {
        private readonly ISubject subject;
        public TemperatureObserver(ISubject subject)
        {
            this.subject = subject;
            this.subject.Add(this);
        }

        public void Update()
        {
            Console.WriteLine($"new Temperature value is {this.subject.GetState()}");
        }
    }

    public class TemperatureObservable : ISubject
    {
        private readonly IList<IObserver> observers = new List<IObserver>();

        private int _temperature;



        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public int GetState()
        {
            return _temperature;
        }

        public void SetState(int state)
        {
            this._temperature = state;
            Notify();
        }
    }

    public static class ObserverClient
    {
        public static void Demo()
        {
            ISubject tempSub = new TemperatureObservable();
            _ = new TemperatureObserver(tempSub);
            tempSub.SetState(10);
        }

    }
    #endregion
}
