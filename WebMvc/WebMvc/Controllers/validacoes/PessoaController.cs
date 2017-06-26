using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc.Models;
using System.Collections.ObjectModel;


namespace WebMvc.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
			Pessoa pessoa = new Pessoa();
            return View(pessoa);
        }
		[HttpPost]
		public ActionResult Index(Pessoa pessoa)
		{
			// DICA: Está comentado por que foi feita validação no model, porém a validação 
			// feita aqui na controller pode ser feita mas só valida no servidor,podendo implicar em performance.

			////Validação feita apenas do lado do servidor.
			//if(string.IsNullOrEmpty(pessoa.Nome))
			//{
			//	// Quando o primeiro parametro está preenchido a mensagem aparece do lado do parametro cetado
			//	ModelState.AddModelError("Nome", "Campo Nome Obrigatório.");
			//}
			////Validação feita apenas do lado do servidor.
			//if ( pessoa.Senha !=  pessoa.ConfirmaSenha)
			//{
			//	// Quando o primeiro parametro está vazio aparece mensagem no validateSumary
			//	ModelState.AddModelError("", "Senha não pode ser diferente");
			//}
			//if (LoginUnico(pessoa.Login)== false)
			//{
			//	ModelState.AddModelError("", "Login já existe");
			//}

			if (ModelState.IsValid)
			{
				return View("Resultado", pessoa);
			}
			return View(pessoa);
		}

		public ActionResult Resultado (Pessoa pessoa)
		{
			return View(pessoa);
		}

		//public ActionResult LoginUnico(string login)
		//{
		//	var BancoColecao = new Collection<string>
		//	{
		//		"paula","Daniela","Esther", "Roberto"
		//	};
		//	return Json(BancoColecao.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet );
		//}

		public bool LoginUnico(string login)
		{
			var BancoColecao = new Collection<string>
			{
				"paula","Daniela","Esther", "Roberto"
			};
			return BancoColecao.All(x => x.ToLower() != login.ToLower());
		}
	}
}