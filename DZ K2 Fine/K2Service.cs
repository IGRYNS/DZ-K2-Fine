using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_K2_Fine
{
    public class K2Service : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private List<string> archive = new List<string>();
        public void NotifyNews()
        {
            foreach (IObserver item in observers)
            {
                item.Update(archive[archive.Count-1]);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void PublishNewsK2(string post)
        {
            archive.Add(post);
            NotifyNews();
        }

        public void NotifyHuman(Dogs dog)
        {
            archive.Add($"Собака: {dog._name}. Штраф 5 приседаний.");
            foreach (IObserver item in observers)
            {
                if (item==dog._myHuman)
                {
                    item.Update(archive[archive.Count-1]);
                }
            }
        }
    }
}
