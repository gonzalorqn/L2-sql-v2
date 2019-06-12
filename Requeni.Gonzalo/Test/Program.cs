using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //AccesoDatos ad = new AccesoDatos();

            //Persona p = new Persona(2, "Rodrigo", "Perez", 62);
            //if (ad.AgregarPersona(p))
            //    Console.WriteLine("Se agrego correctamente");
            //Console.ReadLine();

            //Persona p2 = new Persona(3, "Juan", "Campanella", 84);
            //if(ad.ModificarPersona(p2))
            //    Console.WriteLine("Se modifico correctamente");
            //Console.ReadLine();

            //if (ad.EliminarPersona(6))
            //    Console.WriteLine("Se elimino correctamente");
            //Console.ReadLine();

            //List<Persona> lista = ad.TraerTodos();
            //foreach (Persona item in lista)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            //DataTable tabla = ad.TraerTablaPersonas();
            //Console.ReadLine();
            //string aux = "";
            //foreach (DataRow item in tabla.Rows)
            //{
            //    aux += item["id"] + ", ";
            //    aux += item["nombre"] + ", ";
            //    aux += item["apellido"] + ", ";
            //    aux += item["edad"] + "\n";
            //}
            //Console.WriteLine(aux);
            //Console.ReadLine();
            //tabla.WriteXmlSchema("Personas_esquema.xml");
            //tabla.WriteXml("Personas_datos.xml");
            DataTable tabla = new DataTable();
            tabla.ReadXmlSchema("Personas_esquema.xml");
            tabla.ReadXml("Personas_datos.xml");
            Console.ReadLine();
        }
    }
}
