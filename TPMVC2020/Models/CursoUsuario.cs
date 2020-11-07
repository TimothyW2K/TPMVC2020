using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPMVC2020.Models
{
    public class CursoUsuario
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
