using Microsoft.AspNetCore.Mvc;
using EstoqueMVC.Models;
namespace EstoqueMVC.Controllers;
public class EstoqueController : Controller
{
    private List<Produto> produtos=new(){new(){Id=1,Nome="Notebook",Categoria="Informática",Estoque=0,EstoqueMinimo=2,Preco=3500},new(){Id=2,Nome="Mouse",Categoria="Periféricos",Estoque=8,EstoqueMinimo=5,Preco=80},new(){Id=3,Nome="Teclado",Categoria="Periféricos",Estoque=2,EstoqueMinimo=3,Preco=120},new(){Id=4,Nome="Monitor",Categoria="Informática",Estoque=10,EstoqueMinimo=5,Preco=900},new(){Id=5,Nome="Impressora",Categoria="Informática",Estoque=1,EstoqueMinimo=2,Preco=750},new(){Id=6,Nome="Fone",Categoria="Áudio",Estoque=15,EstoqueMinimo=5,Preco=150},new(){Id=7,Nome="Webcam",Categoria="Acessórios",Estoque=4,EstoqueMinimo=4,Preco=250},new(){Id=8,Nome="SSD",Categoria="Informática",Estoque=3,EstoqueMinimo=5,Preco=420},new(){Id=9,Nome="Pen Drive",Categoria="Acessórios",Estoque=0,EstoqueMinimo=3,Preco=45},new(){Id=10,Nome="Caixa de Som",Categoria="Áudio",Estoque=7,EstoqueMinimo=3,Preco=220},new(){Id=11,Nome="HD",Categoria="Informática",Estoque=2,EstoqueMinimo=4,Preco=300},new(){Id=12,Nome="Cabo HDMI",Categoria="Acessórios",Estoque=20,EstoqueMinimo=5,Preco=50},new(){Id=13,Nome="Roteador",Categoria="Rede",Estoque=1,EstoqueMinimo=2,Preco=180},new(){Id=14,Nome="Memória RAM",Categoria="Informática",Estoque=6,EstoqueMinimo=4,Preco=250},new(){Id=15,Nome="Fonte",Categoria="Informática",Estoque=0,EstoqueMinimo=2,Preco=300}};
    public IActionResult Index()=>View(produtos);
    public IActionResult Baixo()=>View("Baixo",produtos.Where(x=>x.Estoque>0&&x.Estoque<=x.EstoqueMinimo).ToList());
    public IActionResult Esgotados()=>View("Esgotados",produtos.Where(x=>x.Estoque==0).ToList());
    public IActionResult Alertas()=>View("Alertas",produtos.Where(x=>x.Estoque<=x.EstoqueMinimo).ToList());
}
