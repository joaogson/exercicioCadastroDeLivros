using projetoCadastroLivro.Entities;

namespace projetoCadastroLivro.Entities;


public class Cliente : Pessoa
{
	public Cliente(string nome, string cpf) : base(nome, cpf)
	{}
	
	public override void ObterIdentificacao()
	{
		
	}

}