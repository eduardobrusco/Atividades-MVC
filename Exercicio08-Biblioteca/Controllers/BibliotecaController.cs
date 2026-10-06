using Microsoft.AspNetCore.Mvc;
using BibliotecaMVC.Models;
namespace BibliotecaMVC.Controllers;
public class BibliotecaController : Controller
{
    private List<Livro> livros=new(){new(){Id=1,Titulo="Dom Casmurro",Autor="Machado de Assis",Ano=1899,Disponivel=true},new(){Id=2,Titulo="O Cortiço",Autor="Aluísio Azevedo",Ano=1890,Disponivel=false},new(){Id=3,Titulo="Capitães da Areia",Autor="Jorge Amado",Ano=1937,Disponivel=true},new(){Id=4,Titulo="Vidas Secas",Autor="Graciliano Ramos",Ano=1938,Disponivel=true},new(){Id=5,Titulo="Memórias Póstumas",Autor="Machado de Assis",Ano=1881,Disponivel=false},new(){Id=6,Titulo="A Hora da Estrela",Autor="Clarice Lispector",Ano=1977,Disponivel=true},new(){Id=7,Titulo="Grande Sertão",Autor="Guimarães Rosa",Ano=1956,Disponivel=false},new(){Id=8,Titulo="Iracema",Autor="José de Alencar",Ano=1865,Disponivel=true},new(){Id=9,Titulo="O Alienista",Autor="Machado de Assis",Ano=1882,Disponivel=true},new(){Id=10,Titulo="Sítio do Picapau Amarelo",Autor="Monteiro Lobato",Ano=1920,Disponivel=false}};
    public IActionResult Index()=>View(livros);
    public IActionResult Disponiveis()=>View("Index",livros.Where(x=>x.Disponivel).ToList());
}
