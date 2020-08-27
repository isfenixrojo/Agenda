using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static ControlAgenda control = new ControlAgenda(new Agenda());
        static void Main(string[] args)
        {
            string opcion = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Agenda");
                ImprimirMenu();
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        control.VerContacto();
                        break;
                    case "2":
                        control.AgragarContacto();
                        break;
                    case "3":
                        control.BorrarUltimoContacto();
                        break;
                    case "4":
                        control.BuscarPorNombre();
                        break;
                    case "5":
                        ControlAgenda.AcercaDe();
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }
            } while (opcion != "6");
        }

        static void ImprimirMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Ver Contactos");
            sb.AppendLine("2. Agregar Contacto");
            sb.AppendLine("3. Borrar último Contacto");
            sb.AppendLine("4. Buscar Contacto por Nombre");
            sb.AppendLine("5. Acerca de");
            sb.AppendLine("6. Salir");
            sb.Append("Seleccione una opción: ");
            Console.Write(sb.ToString());
        }
    }
}
