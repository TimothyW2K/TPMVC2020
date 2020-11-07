using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPMVC2020.Models;


namespace TPMVC2020.Data
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Lenguaje> Lenguajes { get; set; }
        public DbSet<Nivel> Niveles { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<CursoUsuario> CursoUsuarios { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
