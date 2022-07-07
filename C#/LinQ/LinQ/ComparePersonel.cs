using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class ComparePersonel : IComparer<Personel>
    {
        public int Compare(Personel x, Personel y)
        {
            if (x.Name != y.Name)
            {
                return string.Compare(x.Name, y.Name);
            }
            else
            {
                return string.Compare(x.Surname, y.Surname);
            }
        }
    }
}
