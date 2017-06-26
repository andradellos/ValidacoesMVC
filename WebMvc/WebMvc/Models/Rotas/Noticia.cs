using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace WebMvc.Models.Rotas
{
	public class Noticia
	{
		public int NoticiaId { get; set; }
		public string Titulo { get; set; }
		public string Conteudo { get; set; }
		public string Categoria { get; set; }

		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime Data { get; set; }

		public IEnumerable<Noticia> listaNoticias()
		{
			var retorno = new Collection<Noticia>
		{
			new Noticia
			{ NoticiaId=1, Titulo="Vitótia perde",Conteudo="ai uma vez o time do vitória não consegue passar.",Categoria="Esporte", Data=DateTime.Now },
			new Noticia
			{ NoticiaId=2, Titulo="O jarro",Conteudo="Jarros estão na moda para decoração.",Categoria="Casa", Data= new DateTime(2010,09,01) },
			new Noticia
			{ NoticiaId=3, Titulo="A Carroça",Conteudo="O time do bahia joga tão lento que parece uma carroça.",Categoria="Esporte", Data= new DateTime(2014,01,01)  },
			new Noticia
			{ NoticiaId=4, Titulo="Conseguiu Vencer",Conteudo="Emanuel ganha na loteria e consegue comprar 5 casas na Europa",Categoria="Casa", Data= new DateTime(2016,11,01) },
			new Noticia
			{ NoticiaId=5, Titulo="Cores Quentes",Conteudo="A tendência para 2017 é a pintuda da casa com cores fortes.",Categoria="Casa", Data= new DateTime(2016,11,01) },
			new Noticia
			{ NoticiaId=6, Titulo="TI com trabalho em Alta",Conteudo="A área de TI está super aquecida e cada vez mais almenta o número de oportunidades no mundo.",Categoria="Emprego", Data= new DateTime(2016,11,01) }


		};
			return retorno;
		}
	}

	
}
