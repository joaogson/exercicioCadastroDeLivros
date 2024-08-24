using projetoCadastroLivro.Entities;

namespace projetoCadastroLivro.Entities;

public class Emprestimo
{
	public Livro LivroNome;
	public Cliente ClienteNome;
	public DateTime DataEmprestimo { get; set; }
	public DateTime DataDevolucao { get; set; }
	
	public Emprestimo(Livro livro, Cliente cliente, DateTime dataEmprestimo, DateTime dataDevolucao)
	{
		LivroNome = livro;
		ClienteNome = cliente;
		DataEmprestimo = dataEmprestimo;
		DataDevolucao = dataDevolucao;
	}
}