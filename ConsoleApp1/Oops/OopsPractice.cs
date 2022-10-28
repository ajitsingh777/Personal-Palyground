namespace DSPractice.Oops
{
    internal abstract class Vehicle
    {
        public Vehicle(int x)
        {
            Console.WriteLine("Abstract class Constructor" + x);
        }
        public void wheels()
        {
            Console.WriteLine("4 wheels ");
        }

        public abstract void headlight();
    }
    interface MyInterface
    {

        void MyMethod();

    }
    internal class Car : Vehicle, MyInterface
    {
        public Car(int x) : base(x)
        {

        }
        public void Engine()
        {
            Console.WriteLine("car engine");
        }

        public override void headlight()
        {
            Console.WriteLine("german headlight");
        }

        public void MyMethod()
        {
            throw new NotImplementedException();
        }
    }
}
