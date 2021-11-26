using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
   public class Switch
    {
        Estado _estado;

        public Switch()
        {
            _estado = new Encendido();
        }
        public void DefinirEstado(Estado _e)
        {
            _estado = _e;
        }

        public void Presionar()
        {
            _estado.ControlarEstado(this);
            Console.WriteLine(_estado.Describir());
        }


    }
}
