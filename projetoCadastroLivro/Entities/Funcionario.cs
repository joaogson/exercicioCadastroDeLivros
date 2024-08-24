using projetoCadastroLivro.Entiites;
using projetoCadastroLivro.Entities;

namespace projetoCadastroLivro.Entiites;


public class Funcionario : Pessoa
{
	public Funcionario(string nome, string cpf): base(nome, cpf)
	{}

    public override void ObterIdentificacao()
    {}
}