using Event_Plus.Domains;
using EventPlus.Context;
using Microsoft.EntityFrameworkCore;
using ProjetoEvent_.Interfaces;

namespace EventPlus_.Repositories
{
    public class TipoEventoRepository : ITipoEventoRepository
    {
        private readonly EventContext _context;

        public TipoEventoRepository(EventContext context)
        {
            _context = context;
        }

       
}