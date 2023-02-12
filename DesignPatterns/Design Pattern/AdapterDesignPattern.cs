namespace DesignPatterns.Design_Pattern
{
    #region Description
    /*
        The Adapter design pattern is a structural pattern that allows objects 
        with incompatible interfaces to work together. 
        The pattern involves a class that transfers calls to the target 
        object into the appropriate format. 
    */

    /*
        Problem: Suppose you have a class with a specific interface that you want to use, 
        but its methods don't match the ones you need. In this case, you can't simply 
        inherit from the class and override its methods because you don't want to 
        change its original behavior.
     */

    /* 
        Solution: The Adapter pattern solves this problem by wrapping the class with
        a class that implements the required interface. 
        The adapter class translates calls to the target object into the appropriate format. 
        This way, you can use the target object as if it implements the required interface.
     */
    #endregion


    #region Implementation
    public interface IBird
    {
        void MakeSound();
    }

    public interface IToy
    {
        void Squeak();
    }
    public class Sparrow : IBird
    {
        public void MakeSound()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
    public class ToySparrow : IToy
    {
        public void Squeak()
        {
            Console.WriteLine("squeak");
        }
    }

    /// <summary>
    /// By using Adapter Toy interface adapting the functionality of Bird
    /// </summary>
    public class Adapter : IToy
    {
        private readonly IBird bird;
        public Adapter(IBird bird)
        {
            this.bird = bird;
        }

        public void Squeak()
        {
            bird.MakeSound();
        }
    } 
    #endregion
}
