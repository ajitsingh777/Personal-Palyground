﻿namespace DesignPatterns.Design_Pattern
{
    #region Description
    /*
        The Singleton design pattern is a creational design pattern that ensures a class has only one instance and provides
        a global point of access to that instance.
     */
    /*
        Problem/Solution:The Singleton pattern solves the problem of having multiple instances of a class in a program, 
        which can cause issues like:

        Inefficient resource usage: Multiple instances of a class can use up more memory than necessary, especially if the class maintains 
        state or has complex initialization.

        Inconsistent state: If multiple instances of a class are created and manipulated, it can lead to inconsistencies in the state
        of the program.

        Conflicting behavior: If multiple instances of a class are created and manipulated, it can lead to conflicts between
        the different instances, especially if they are accessing shared resources.

        By ensuring that only one instance of a class exists, the Singleton pattern helps to address these issues and provides a
        standard way to access the instance of the class.

        The Singleton pattern is widely used in situations where there can be only one instance of a class, such as:

        Database connection management: Only one instance of a database connection manager should exist in a program.

        Configuration management: Only one instance of a configuration manager should exist in a program.

        Logging: Only one instance of a logger should exist in a program.
     */
    #endregion

    #region Implementation
    public sealed class MySingletonObjectWithLock
    {
        private MySingletonObjectWithLock()
        {

        }

        private static MySingletonObjectWithLock? _instance = null;
        private static readonly object _instanceLock = new object();
        public static MySingletonObjectWithLock Instance
        {
            get
            {
                ///double check of null object before acquiring lock
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new MySingletonObjectWithLock();
                        }
                    }
                }
                return _instance;
            }
        }
    }
    #endregion
}
