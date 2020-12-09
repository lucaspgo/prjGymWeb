using prjCapeloWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCapeloWeb.DAL
{
    public class GrupoMuscularDAO
    {
        private readonly Context _context;

        public GrupoMuscular BuscarPorId(int id) => _context.GruposMusculares.Find(id);

        public void Remover(int id)
        {
            _context.GruposMusculares.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
    }
}
