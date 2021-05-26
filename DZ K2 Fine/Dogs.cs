using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_K2_Fine
{
    public class Dogs
    {
        public string _name { get; set; }
        public string _breed { get; set; }
        public Humans _myHuman { get; set; }

        public void SetHuman(Humans human)
        {
            _myHuman = human;
        }
    }
}
