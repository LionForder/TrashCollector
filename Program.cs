using System;

namespace TrashCollector
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Destruct first = new Destruct();
            Destruct second = new Destruct();
            Destruct third = new Destruct();
            // достаточно будет удалить ссылку
            first = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine(second.deleted);
            Console.WriteLine(third.deleted);
            second = third;
            second.deleted = true; // ссылается на third => и его изменяет

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine(second.deleted);
            Console.WriteLine(third.deleted);

        }
    }
}
