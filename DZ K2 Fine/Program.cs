using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_K2_Fine
{
    class Program
    {
        static void Main(string[] args)
        {
            K2Service k2Service = new K2Service();

            Humans Karl = new Humans { _name = "Karl" };
            Humans Sem = new Humans { _name = "Sem" };

            Dogs Barry = new Dogs
            {
                _breed = "Kolly",
                _name = "Barry"
            };
            Dogs Bob = new Dogs
            {
                _breed = "Kolly",
                _name = "Bob"
            };
            Dogs Larry = new Dogs
            {
                _breed = "Shpitz",
                _name = "Larry"
            };
            Dogs Lara = new Dogs
            {
                _breed = "Kolly",
                _name = "Lara"
            };

            Karl.AddNewDog(Barry);
            Karl.AddNewDog(Bob);
            Sem.AddNewDog(Larry);
            Sem.AddNewDog(Lara);


            k2Service.RegisterObserver(Karl);
            k2Service.RegisterObserver(Sem);

            k2Service.PublishNewsK2("K2Service теперь открыта!");
            Console.WriteLine();

            k2Service.NotifyHuman(Bob);
            k2Service.NotifyHuman(Lara);


            Console.ReadKey();
        }
    }
}
