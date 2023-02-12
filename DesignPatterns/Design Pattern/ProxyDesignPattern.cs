namespace DesignPatterns.Design_Pattern
{

    #region Description
    /*
        The proxy design pattern is a structural design pattern that provides a 
        surrogate or placeholder object for another object to control access to it. 
        The proxy object has the same interface as the original object, so the client 
        code can work with the original object without knowing the difference. 
        The proxy can be used to provide additional functionality such as lazy loading, access control, 
        or caching, or it can be used to perform tasks such as counting the number of calls to a method, 
        logging method calls, or timing method execution.

        There can be multiple proxy objects(servers) between client and real object. every next proxy object will work as real object for 
        current proxy object.
     */

    /*
        Problem/Solution: Suppose you have to block some website in your university(restrictive access) or have to cache real object and deciding 
        wheter to use cached object or make call to real object(it can be because of real object is expensive to create) or you have to
        pre-processing or post-processing(logging, publish event etc) at every request. In these all scenario we can use proxy object(server).
     */
    #endregion

    #region Implementation
    public interface IEmployee
    {
        void create(string client, string name);
        void Delete(string client, string name);
        void Get(string client, string name);
    }

    public class Employee : IEmployee
    {
        public void create(string client, string name)
        {
            Console.WriteLine($"Employee created with name {name}");
        }

        public void Delete(string client, string name)
        {
            Console.WriteLine($"Employee deleted with name {name}");
        }

        public void Get(string client, string name)
        {
            Console.WriteLine($"Employee with name {name}");
        }
    }

    /// <summary>
    /// Proxy object that we are using to implement restrictive access 
    /// similarly we can use proxy object for caching, pre/post processing etc
    /// </summary>
    public class ProxyEmployee : IEmployee
    {
        private readonly Employee employee;

        public ProxyEmployee()
        {
            if (employee == null)
            {
                employee = new Employee();
            }
        }
        public void create(string client, string name)
        {
            if (client.Equals("ADMIN"))
            {
                employee.create(client, name);
                return;
            }

            throw new MethodAccessException("Access denied");

        }

        public void Delete(string client, string name)
        {
            if (client.Equals("ADMIN"))
            {
                employee.Delete(client, name);
                return;
            }

            throw new MethodAccessException("Access denied");
        }

        public void Get(string client, string name)
        {
            if (client.Equals("ADMIN") || client.Equals("USER"))
            {
                employee.Get(client, name);
                return;
            }

            throw new MethodAccessException("Access denied");
        }
    } 
    #endregion
}
