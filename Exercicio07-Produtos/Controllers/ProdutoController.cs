using Microsoft.AspNetCore.Mvc;
using ProdutosMVC.Models;
namespace ProdutosMVC.Controllers;
public class ProdutoController : Controller
{
    private List<Produto> produtos=new(){new(){Id=1,Nome="Notebook",Categoria="Informática",Estoque=5,Preco=3500},new(){Id=2,Nome="Mouse",Categoria="Periféricos",Estoque=20,Preco=80},new(){Id=3,Nome="Teclado",Categoria="Periféricos",Estoque=0,Preco=120},new(){Id=4,Nome="Monitor",Categoria="Informática",Estoque=8,Preco=900},new(){Id=5,Nome="Impressora",Categoria="Informática",Estoque=2,Preco=750},new(){Id=6,Nome="Fone",Categoria="Áudio",Estoque=15,Preco=150},new(){Id=7,Nome="Webcam",Categoria="Acessórios",Estoque=4,Preco=250},new(){Id=8,Nome="SSD",Categoria="Informática",Estoque=10,Preco=420},new(){Id=9,Nome="Pen Drive",Categoria="Acessórios",Estoque=0,Preco=45},new(){Id=10,Nome="Caixa de Som",Categoria="Áudio",Estoque=7,Preco=220}};
    public IActionResult Index()=>View(produtos);
    public IActionResult Disponiveis()=>View("Index",produtos.Where(x=>x.Estoque>0).ToList());
}
