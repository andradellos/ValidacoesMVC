using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebMvc
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Todas as Notícias",
				url: "noticias/",
				defaults: new { controller = "Noticia", action = "TodasAsNoticias" }
			);
			routes.MapRoute(
				name: "Todas as Notícia",
				url: "noticias/{categoria}/{titulo}-{noticiaId}",
				defaults: new { controller = "Noticia", action = "MostraNoticia" }
			);

			routes.MapRoute(
				name: "Mostra Categorias",
				url: "noticias/{categoria}",
				defaults: new { controller = "Noticia", action = "MostraCategoria" }
			);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Pessoa", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
