using projetoCadastroLivro.Entities;

namespace projetoCadastroLivro.Entiites;


public class Cliente : Pessoa
{
	public Cliente(string nome, string cpf) : base(nome, cpf)
	{}
	
	public override void ObterIdentificacao()
	{
		
	}

}