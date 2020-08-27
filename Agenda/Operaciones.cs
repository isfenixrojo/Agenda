using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Operaciones : IOperaciones
    {
        public string AgregarContacto()
        {
            return "Agregar Contacto";
        }
        public string VerContactos()
        {
            return "Ver Contactos";
        }
        public string BorrarUltimoContacto()
        {
            return "Borrar Ultimo Contacto";
        }
    }
}
