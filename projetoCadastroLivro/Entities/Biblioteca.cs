using projetoCadastroLivro.Entities;

namespace projetoCadastroLivro.Entities;

public class Biblioteca
{
	
	private List<Livro> livroRepositorio = new List<Livro>();
	private List<Cliente> clienteRepositorio = new List<Cliente>();
	
	public Biblioteca()
	{}
	
	public void RegistrarEmprestimo(Livro livro, Cliente cliente)
	{
		
	}
}