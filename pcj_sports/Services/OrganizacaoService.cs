using pcj_sports.Contexto;
using pcj_sports.Models;

namespace pcj_sports.Services
{
    public class OrganizacaoService
    {
        private readonly ContextBD _context;

        public OrganizacaoService(ContextoBD con)
        {
            _context = con;
        }

        public async Task<List<Organizacao>>? Organizacoes()
        {
            var organizacoes = _context.Organizacoes?.ToList();
            return organizacoes;
        }

        public async Task<Organizacao>? GetOrganizacao(int id)
        {
            var organizacao = _context.Organizacoes?.Where(p => p.Id == id).FirstOrDefault();
            return organizacao;
        }

        public async Task<Organizacao> GetOrganizacao(string cnpj)
        {
            var organizacao = _context.Organizacoes?.Where(organizacao => p.Cnpj == cnpj).FirstOrDefault();
            return organizacao;
        }

        public async Task Add(Organizacao organizacao)
        {
            _context.Organizacoes?.Add(organizacao);
        }
    }
}
