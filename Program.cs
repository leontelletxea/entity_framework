using System;
using System.Collections.Generic;
using System.Linq; // libreria para traer todos los registros con el ToList()

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba de Entity Framework Code First");


            // Agregar un estudiante
            using (var contexto = new ContextoEscuela())
            {
                ////Insert
                //var e = new Estudiante()
                //{
                //    apellido = "Juarez",
                //    nombre = "Pedro",
                //    email = "pedro@gmail.com"
                //};
                //contexto.Estudiantes.Add(e);
                //contexto.SaveChanges();
                //Console.WriteLine("Estudiante agregado!");

                ////Modificar Estudiante
                //var std = contexto.Estudiantes.Find(1);
                //std.email = "juan@gmail.com";
                //contexto.SaveChanges();
                //Console.WriteLine("Se modificó el estudiante 1, consulte la base de datos ");

                ////Eliminar Estudiante
                //var std2 = contexto.Estudiantes.Find(5);
                //contexto.Estudiantes.Remove(std2);
                //contexto.SaveChanges();
                //Console.WriteLine("Se eliminó el estudiante 11, consulte la base de datos ");

                ////Select con where
                //Estudiante estudiante = contexto.Estudiantes.Find(1);
                //Console.WriteLine(estudiante.nombre);

                //Select sin where
                var estudiantes = (from s in contexto.Estudiantes select s).ToList();

                foreach (var item in estudiantes)
                {
                    Console.WriteLine($"Alumno {item.nombre} {item.apellido} {item.email}");
                }
            }

            Console.ReadKey();


            //buscar con método containts de Linq
            //https://www.entityframeworktutorial.net/querying-entity-graph-in-entity-framework.aspx

        }
    }
}
