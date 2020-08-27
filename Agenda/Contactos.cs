using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contactos : IComparable<Contactos>
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Contactos()
        {

        }
        public Contactos(string nombre, string telefono, string email)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Contactos c = obj as Contactos;
            if (c == null)
            {
                return false;
            }
            return string.Equals(Nombre, c.Nombre) && string.Equals(Telefono, c.Telefono);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hasNombre = (Nombre != null ? Nombre.GetHashCode() : 0);
                int hasTelefono = (Telefono != null ? Telefono.GetHashCode() : 0);
                return (hasNombre * 397) ^ (hasTelefono);
            }
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}\nTelefono: {1}\nEmail: {2}\n", Nombre, Telefono, Email);
        }

        public int CompareTo(Contactos other)
        {
            return Nombre.CompareTo(other.Nombre);
        }
    }
}