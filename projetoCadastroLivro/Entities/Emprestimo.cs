using projetoCadastroLivro.Entities;

namespace projetoCadastroLivro.Entities;

public class Emprestimo
{
	public List<Livro> livros = new List<Livro>();
	public List<Cliente> clientes = new List<Cliente>();
	public DateTime DataEmprestimo { get; set; }
	public DateTime DataDevolucao { get; set; }
	
	public Emprestimo(DateTime dataEmprestimo, DateTime dataDevolucao)
	{
		DataEmprestimo = dataEmprestimo;
		DataDevolucao = dataDevolucao;
	}
}