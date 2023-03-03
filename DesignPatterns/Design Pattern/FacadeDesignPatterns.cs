namespace DesignPatterns.Design_Pattern
{
    #region Description
    /*
        The Facade design pattern is a structural design pattern that provides a simple interface to a complex system of classes, 
        libraries, or frameworks. It aims to simplify the interaction between a client and a complex subsystem by providing a higher-level
        interface that hides the implementation details of the subsystem.
     */

    /*
        Problem/Solution : 
        The Facade design pattern is used to simplify the interface of a complex system, making it easier to use and understand. 
        It provides a unified interface to a set of interfaces in a subsystem, making the subsystem easier to use.

        The problem that the Facade pattern solves is that of a complex system that has many components with varying interfaces. 
        In such a system, it can be difficult to understand how to use the system, and it can also be time-consuming to integrate  
        the different components of the system. The Facade pattern simplifies the interface to the system by providing a single, 
        unified interface that hides the complexity of the underlying subsystem.

        By providing a simplified interface, the Facade pattern makes it easier to use the system, reducing the need for the 
        user to understand the details of the subsystem. It also makes it easier to integrate the different components of the system, 
        as the Facade provides a single point of contact for the subsystem. Overall, the Facade pattern helps to improve the usability, 
        maintainability, and extensibility of complex systems.
     */
    #endregion
    #region Implementation

    using System;

    // Subsystem classes
    class SubsystemA
    {
        public void OperationA()
        {
            Console.WriteLine("Subsystem A operation");
        }
    }

    class SubsystemB
    {
        public void OperationB()
        {
            Console.WriteLine("Subsystem B operation");
        }
    }

    // Facade class
    class Facade
    {
        private readonly SubsystemA subsystemA;
        private readonly SubsystemB subsystemB;

        public Facade()
        {
            subsystemA = new SubsystemA();
            subsystemB = new SubsystemB();
        }

        public void Operation1()
        {
            Console.WriteLine("Facade operation 1");
            subsystemA.OperationA();
            subsystemB.OperationB();
        }

        public void Operation2()
        {
            Console.WriteLine("Facade operation 2");
            subsystemB.OperationB();
        }
    }

    // Client class
    static class FacadeClient
    {
        static void Main()
        {
            Facade facade = new Facade();

            facade.Operation1();
            facade.Operation2();

            Console.ReadKey();
        }
    }

    #endregion
}
