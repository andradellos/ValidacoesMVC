using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc.Models.Rotas;

namespace WebMvc.Controllers.Rotas
{
    public class NoticiaController : Controller
    {

		private readonly IEnumerable<Noticia> TodasNoticias;

		public NoticiaController()
		{
			TodasNoticias = new Noticia().listaNoticias().OrderByDescending(x => x.Data);
		}

		public ActionResult Index()
        {
			var ultimasNoticias = TodasNoticias.Take(3);
			var todasCatgoria = TodasNoticias.Select(x => x.Categoria).Distinct();

			ViewBag.Categorias = todasCatgoria;


			return View(ultimasNoticias);
        }

		public ActionResult TodasAsNoticias()
		{
			return View(TodasNoticias);
		}
		public ActionResult MostraNoticia(int noticiaId, string titulo, string categoria)
		{
			return View(TodasNoticias.FirstOrDefault(x => x.NoticiaId == noticiaId));
		}
		public ActionResult MostraCategoria(string categoria)
		{
			var categoriaspecifica = TodasNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
			ViewBag.categoria = categoria;
			return View(categoriaspecifica);
		}
	}
}