using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class StandBy : Estado
    {
        public override void ControlarEstado(Switch s)
        {
            s.DefinirEstado(new Encendido());
        }

        public override string Describir()
        {
            return "Estado stand by";
        }
    }
}
