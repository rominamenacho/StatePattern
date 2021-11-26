using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class Estado
    {
        public abstract void ControlarEstado(Switch s);
        public abstract string Describir();
    }
}
