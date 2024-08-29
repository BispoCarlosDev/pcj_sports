using pcj_sports.Contexto;
using pcj_sports.Models;

namespace pcj_sports.Services
{
    public class ModalidadeService
    {
        private readonly ContextBD _context;

        public ModalidadeService(ContextoBD con)
        {
            _context = con;
        }

        public async Task<List<Modalidade>>? Modalidades()
        {
            var modalidades = _context.Modalidades?.ToList();
            return modalidades;
        }

        public async Task<Modalidade>? GetModalidade(int id)
        {
            var modalidade = _context.Modalidades?.Where(p => p.Id == id).FirstOrDefault();
            return modalidade;
        }

        public async Task<Modalidade> GetModalidade(string nome)
        {
            var modalidade = _context.Modalidades?.Where(modalidade => p.Nome == nome).FirstOrDefault();
            return modalidade;
        }

        public async Task Add(Modalidade modalidade)
        {
            _context.Modalidades?.Add(modalidade);
        }
    }
}
