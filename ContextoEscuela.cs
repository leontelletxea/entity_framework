using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst
{
    public class ContextoEscuela : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
            optionsBuilder.UseSqlServer(@"Server=leontelletxea\SQLEXPRESS;Database=SchoolDBCF;Trusted_Connection=True;");
        }


        //consola para ejecutar las migraciones:
        //herramientas => administrador de paquetes nuget => consola de administrador de paquetes 
        //add-migration nombre_migracion => generar la migracion de entity framework 
        //update-database -verbose => ejecutar esa migracion creada

    }
}
