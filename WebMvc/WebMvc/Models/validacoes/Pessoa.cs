using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebMvc.Models
{
	public class Pessoa
	{
		//Dica:
		//Usar a validação no model ao invés de usá-la no controller faz com que a validação possa acontecer
		// tanto do lado do servidor como do cliente
		//---------------------------------------------------------------

		[Required(ErrorMessage ="Nome obrigatório")]
		public string Nome { get; set; }

		[StringLength(50,MinimumLength =5,ErrorMessage ="De 5 até 50 caracteres.")]
		public string Observacao { get; set; }

		[Range(18,50, ErrorMessage="Entre 18 e 50 anos.")]
		public int Idade { get; set; }

		[RegularExpression(@"^[\w][\w\.]+@\w+\.{1}[\w+\.?]*[\w]+$", ErrorMessage ="Formato email errado")]
		public string Email { get; set; }


		[Required(ErrorMessage ="Campo login Obrigatório")]
		//Remote faz uma validação via ajax, cada letra digitada irá fazer uma verificação no servidor.
		//Nesse caso está recebendo um booleano da Action LoginUnico da Controller Pessoa.
		//FALSE = não validou e TRUE = Validado
		[Remote ("LoginUnico","Pessoa", ErrorMessage = "Login já existe.")]
		public string Login { get; set; }

		public string Senha { get; set; }

		[System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "Senhas diferentes")]
		public string ConfirmaSenha { get; set; }

		[DisplayFormat(DataFormatString ="0:dd/MM/yyyy")]
		public DateTime Datanascimento { get; set; }
	}
}
