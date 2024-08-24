using projetoCadastroLivro.Entities;

namespace projetoCadastroLivro.Entities;

public class Emprestimo
{
	public Livro livro;
	public Cliente cliente;
	public DateTime DataEmprestimo { get; set; }
	public DateTime DataDevolucao { get; set; }
	
	public Emprestimo(DateTime dataEmprestimo, DateTime dataDevolucao)
	{
		DataEmprestimo = dataEmprestimo;
		DataDevolucao = dataDevolucao;
	}
}