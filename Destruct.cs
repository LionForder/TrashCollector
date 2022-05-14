using System;

namespace TrashCollector
{
    public class Destruct
    {
        protected internal bool deleted = false;

        public Destruct()
        {
            Console.WriteLine("Object has been to created!");
        }
        ~Destruct()
        {
            Console.WriteLine("Object has been to deleted!");
        }
    }
}
