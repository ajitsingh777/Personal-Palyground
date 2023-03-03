namespace DesignPatterns.Design_Pattern
{
    #region Description
    /*
        The Builder design pattern is a creational pattern that separates the construction of complex objects from their representation.
        It allows you to create different representations of an object using the same construction process.
        The pattern consists of four main components: the builder, the concrete builder, the director, and the product. 
        The builder defines the interface for creating parts of the product. The concrete builder implements the builder interface 
        and constructs the parts of the product. The director defines the order in which to build the parts, and the product represents
        the complex object being built.
     */
    /*
        Problem/Solution : The Builder design pattern solves the problem of creating complex objects with many optional properties. 
        The traditional approach to building such objects is to use a constructor with many parameters, but this can quickly become 
        unwieldy and hard to use. The Builder pattern provides a solution by separating the construction of an object from its representation,
        so that different representations of the same object can be created using the same construction process.
        For example, imagine we want to create a car object with many optional properties, such as make, model, year, color, and horsepower. 
        Without the Builder pattern, we might create a constructor with many parameters.

        However, if we want to create a car object with only some of these properties, we must pass null or default values for the other properties, which can be 
        error-prone and hard to read. Additionally, if we add new optional properties in the future, we must modify the constructor and all calls to it.

        With the Builder pattern, we can define a separate builder object that allows us to create a car object with only the
        desired properties. The builder object provides methods for setting each optional property, and a separate method for creating the
        car object. This allows us to create a car object with only the desired properties, without having to pass null or default values
        for the other properties. Additionally, if we add new optional properties in the future, we can modify the builder object without
        having to modify the car object or any calls to it.
     */
    #endregion
    #region Implementation
    public class Car
    {
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Color { get; set; } = string.Empty;
        public int HorsePower { get; set; }

        public override string ToString()
        {
            return $"Car Manufetcturer : {Make} " +
                   $"Car Model : {Model} " +
                   $"Year : {Year} " +
                   $"Car Color: {Color} " +
                   $"Car Power: {HorsePower}";
        }
    }

    public interface ICarBuilder
    {
        void SetMake(string make);
        void SetModel(string model);
        void SetYear(int year);
        void SetColor(string color);
        void SetHorsepower(int horsepower);
        Car GetCar();
    }

    public class CarBuilder : ICarBuilder
    {
        private readonly Car car = new Car();
        public Car GetCar()
        {
            return car;
        }

        public void SetColor(string color)
        {
            car.Color = color;
        }

        public void SetHorsepower(int horsepower)
        {
            car.HorsePower = horsepower;
        }

        public void SetMake(string make)
        {
            car.Make = make;
        }

        public void SetModel(string model)
        {
            car.Model = model;
        }

        public void SetYear(int year)
        {
            car.Year = year;
        }
    }

    public class CarDirector
    {
        private readonly ICarBuilder builder;

        public CarDirector(ICarBuilder carBuilder)
        {
            this.builder = carBuilder;
        }

        public void BuildSportsCar()
        {
            builder.SetMake("Ferrari");
            builder.SetModel("488 GTB");
            builder.SetYear(2020);
            builder.SetColor("Red");
            builder.SetHorsepower(660);
        }

        public void BuildSUVCar()
        {
            builder.SetMake("Jeep");
            builder.SetModel("Grand Cherokee");
            builder.SetYear(2021);
            builder.SetColor("Black");
            builder.SetHorsepower(295);
        }
    }

    public static class BuilderClient
    {
        public static void Demo()
        {
            ICarBuilder builder = new CarBuilder();
            CarDirector director = new CarDirector(builder);
            director.BuildSportsCar();
            Car sportsCar = builder.GetCar();
            Console.WriteLine(sportsCar.ToString());
            director.BuildSUVCar();
            Car SuvCar = builder.GetCar();
            Console.WriteLine(SuvCar.ToString());
        }
    }
    #endregion
}

