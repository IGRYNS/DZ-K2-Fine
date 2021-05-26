using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_K2_Fine
{
    public class Humans : IObserver
    {
        public string _name { get; set; }
        private List<Dogs> _myDogs = new List<Dogs>();

        public void AddNewDog(Dogs dog)
        {
            _myDogs.Add(dog);
            dog._myHuman = this;
        }

        public void Update(string story)
        {
            Console.WriteLine($"{_name}: {story}");
        }
    }
}
