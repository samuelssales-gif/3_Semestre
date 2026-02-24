using FilmesTorloni.WebAPI.Interfaces;
using FilmeTorloni.WebAPI.BdContextFilmes;
using FilmeTorloni.WebAPI.Models;

namespace FilmeTorloni.WebAPI.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly FilmesContext _context;
        public GeneroRepository(FilmesContext context)
        {
            _context = context;
        }

        public void AtualizarIdCorpo(Genero generoAtualizado)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(Guid id, Genero generoAtualizado)
        {
            throw new NotImplementedException();
        }

        public Genero BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                _context.Generos.Add(novoGenero);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
