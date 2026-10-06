using Microsoft.AspNetCore.Mvc;
using EletronicosMVC.Models;
namespace EletronicosMVC.Controllers;
public class EletronicoController : Controller
{
    private List<Eletronico> produtos=new(){new(){Id=1,Nome="Notebook",Marca="Dell",Categoria="Informática",Preco=3500,Estoque=4},new(){Id=2,Nome="Smartphone",Marca="Samsung",Categoria="Celular",Preco=2200,Estoque=8},new(){Id=3,Nome="Tablet",Marca="Lenovo",Categoria="Tablet",Preco=1400,Estoque=0},new(){Id=4,Nome="Monitor",Marca="LG",Categoria="Informática",Preco=900,Estoque=6},new(){Id=5,Nome="Teclado",Marca="Logitech",Categoria="Periféricos",Preco=180,Estoque=12},new(){Id=6,Nome="Mouse",Marca="Logitech",Categoria="Periféricos",Preco=90,Estoque=20},new(){Id=7,Nome="TV",Marca="Samsung",Categoria="Televisão",Preco=2800,Estoque=3},new(){Id=8,Nome="Fone",Marca="JBL",Categoria="Áudio",Preco=250,Estoque=10},new(){Id=9,Nome="Impressora",Marca="HP",Categoria="Informática",Preco=800,Estoque=0},new(){Id=10,Nome="Console",Marca="Sony",Categoria="Games",Preco=3500,Estoque=2},new(){Id=11,Nome="Câmera",Marca="Canon",Categoria="Fotografia",Preco=3000,Estoque=1},new(){Id=12,Nome="Smartwatch",Marca="Xiaomi",Categoria="Wearables",Preco=500,Estoque=7}};
    public IActionResult Index()=>View(produtos);
    public IActionResult EmEstoque()=>View("EmEstoque",produtos.Where(x=>x.Estoque>0).ToList());
    public IActionResult Categoria(string nome="Informática")=>View("Categoria",produtos.Where(x=>x.Categoria.Equals(nome,StringComparison.OrdinalIgnoreCase)).ToList());
    public IActionResult AbaixoDe(decimal valor=1000)=>View("AbaixoDe",produtos.Where(x=>x.Preco<valor).ToList());
}
