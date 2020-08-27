using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class ControlAgenda
    {
        private Agenda _agenda;
        public ControlAgenda(Agenda agenda)
        {
            _agenda = agenda;
        }
        public void VerContacto()
        {
            Limpiar();
            MenuMostrar();
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Contacto Orden Ascendente");
                    _agenda.MostrarOrdenados();
                    break;
                case "2":
                    Console.WriteLine("Contacto Orden Descendente");
                    _agenda.MostrarOrdenadosDesc();
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            PresionaParaContinuar();
        }

        public void BorrarUltimoContacto()
        {
            Limpiar();
            _agenda.BorrarUltimoContacto();
            Console.WriteLine("Contacto borrado exitosamente");
            PresionaParaContinuar();
        }

        public void BuscarPorNombre()
        {
            Limpiar();
            Console.WriteLine("Buscar contacto");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Contactos contactos = _agenda.BuscarPorNombre(nombre);
            if (contactos != null)
            {
                Console.WriteLine("Datos: \n" + contactos);
            }
            else
            {
                Console.WriteLine("Contacto no encontrado");
            }
            PresionaParaContinuar();
        }

        public static void AcercaDe()
        {
            Limpiar();
            Console.WriteLine("Nombre: Israel Hernandez");
            PresionaParaContinuar();
        }
        public void AgragarContacto()
        {
            Limpiar();
            Console.WriteLine("Nuevo contacto");
            Contactos contactos = new Contactos();
            Console.Write("Nombre: ");
            contactos.Nombre = Console.ReadLine();
            Console.Write("Telefono: ");
            contactos.Telefono = Console.ReadLine();
            Console.Write("Email: ");
            contactos.Email = Console.ReadLine();
            _agenda.AgregarContacto(contactos);
            Console.WriteLine("Contacto agregado exitosamente");
            PresionaParaContinuar();
        }

        public void MenuMostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Mostrar orden ascendente");
            sb.AppendLine("2. Mostrar orden descendente");
            sb.AppendLine("3. Volver al menu princípal");
            sb.Append("Seleccióne una opción: ");
            Console.WriteLine(sb.ToString());
        }

        private static void PresionaParaContinuar()
        {
            Console.WriteLine("Presióna cualquier tecla para continuar");
            Console.ReadKey();
        }

        public static void Limpiar()
        {
            Console.Clear();
        }
    }
}
