using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class CompareEqualityPersonel : IEqualityComparer<Personel>
    {
        public bool Equals(Personel x, Personel y)
        {
            if(x.Name == y.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Personel obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
