

using System.Runtime.CompilerServices;

namespace DesignPatterns.Design_Pattern
{
    #region Description
    /*
        The Strategy Design Pattern is a behavioral design pattern that defines a family of algorithms, 
        encapsulates each one, and makes them interchangeable.The strategy pattern lets the algorithm vary 
        independently from clients that use it.
     */

    /*
        Problem/Solution : The strategy design pattern solves the problem of having a class that performs a particular behavior
        that needs to be changed at runtime based on a set of rules or algorithms. In traditional object-oriented programming, 
        this problem is solved by creating subclasses for each algorithm and using inheritance to select the desired behavior at runtime. 
        However, this approach can result in a large number of subclasses, making the code difficult to maintain and scale.

        The strategy pattern provides a way to encapsulate algorithms in separate classes, making it possible to switch between
        algorithms dynamically at runtime. This allows you to replace the algorithm without changing the client code that uses it. 
        As a result, you can easily add new algorithms or change existing ones without affecting the rest of the system. 
        This makes the code more flexible, maintainable, and scalable.

        In summary, the strategy pattern solves the problem of having to change the behavior of a system based 
        on a set of algorithms or rules. It provides a flexible and maintainable way to encapsulate algorithms  
        in separate classes and switch between them dynamically at runtime.
     
     */
    #endregion

    #region Implementation
    public interface IDriveStrategy
    {
        public void drive();
    }


    public class SpecialDriveStartegy : IDriveStrategy
    {
        public void drive()
        {
            Console.WriteLine("Special drive capablities");
        }
    }

    public class NormalDriveStartegy : IDriveStrategy
    {
        public void drive()
        {
            Console.WriteLine("Normal drive capablities");
        }
    }

    public class Vehicle
    {
        private readonly IDriveStrategy driveStrategy;
        public Vehicle(IDriveStrategy driveStrategy)
        {
            this.driveStrategy = driveStrategy;
        }

        public void Drive()
        {
            this.driveStrategy.drive();
        }
    }

    public class SportsVehicle : Vehicle
    {

        public SportsVehicle(IDriveStrategy driveStrategy) : base(driveStrategy)
        {

        }

        /// some other stuff related to sports vehicle
    }

    public class MountainVehicle : Vehicle
    {

        public MountainVehicle(IDriveStrategy driveStrategy) : base(driveStrategy)
        {

        }

        /// some other stuff related to Mountain vehicle
    }

    public class NormalVehicle : Vehicle
    {

        public NormalVehicle(IDriveStrategy driveStrategy) : base(driveStrategy)
        {

        }

        /// some other stuff related to Mountain vehicle
    }

    public class VehicleClient
    {
        public void Show()
        {
            /// here sports and mountain vehicles need same drive capablities, so if we implement it by inheritance 
            /// then there will be duplicate code for montain and sports vehicle class, so it's better to define strategy algorithm 
            /// according to need and interchange them at runtime
            Vehicle vehicle = new SportsVehicle(new SpecialDriveStartegy());
            vehicle.Drive();
            vehicle = new MountainVehicle(new SpecialDriveStartegy());
            vehicle.Drive();
            vehicle = new NormalVehicle(new NormalDriveStartegy());
            vehicle.Drive();
        }

    } 
    #endregion
}
