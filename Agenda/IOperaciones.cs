using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    interface IOperaciones
    {
        string AgregarContacto();
        string VerContactos();
        string BorrarUltimoContacto();
    }
}
