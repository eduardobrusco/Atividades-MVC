using Microsoft.AspNetCore.Mvc;
using PedidosMVC.Models;
namespace PedidosMVC.Controllers;
public class PedidoController : Controller
{
    private List<Pedido> pedidos=new(){new(){Id=1,Cliente="Ana",Produto="X-Burger",Quantidade=2,PrecoUnitario=18,Status="Recebido"},new(){Id=2,Cliente="Bruno",Produto="Batata",Quantidade=1,PrecoUnitario=12,Status="Em preparo"},new(){Id=3,Cliente="Carla",Produto="X-Salada",Quantidade=2,PrecoUnitario=20,Status="Pronto"},new(){Id=4,Cliente="Daniel",Produto="Suco",Quantidade=3,PrecoUnitario=7,Status="Entregue"},new(){Id=5,Cliente="Eduardo",Produto="Pizza",Quantidade=1,PrecoUnitario=45,Status="Em preparo"},new(){Id=6,Cliente="Fernanda",Produto="Lanche",Quantidade=2,PrecoUnitario=22,Status="Pronto"},new(){Id=7,Cliente="Gabriel",Produto="Refrigerante",Quantidade=2,PrecoUnitario=6,Status="Entregue"},new(){Id=8,Cliente="Helena",Produto="Combo",Quantidade=1,PrecoUnitario=35,Status="Recebido"},new(){Id=9,Cliente="Igor",Produto="Pastel",Quantidade=3,PrecoUnitario=9,Status="Em preparo"},new(){Id=10,Cliente="Julia",Produto="Milk-shake",Quantidade=1,PrecoUnitario=15,Status="Entregue"}};
    public IActionResult Index()=>View(pedidos);
    public IActionResult EmPreparo()=>View("EmPreparo",pedidos.Where(x=>x.Status=="Em preparo").ToList());
    public IActionResult Prontos()=>View("Prontos",pedidos.Where(x=>x.Status=="Pronto").ToList());
    public IActionResult Entregues()=>View("Entregues",pedidos.Where(x=>x.Status=="Entregue").ToList());
    public IActionResult Resumo()=>View(pedidos);
}
