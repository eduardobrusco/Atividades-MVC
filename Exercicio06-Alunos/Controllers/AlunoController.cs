using Microsoft.AspNetCore.Mvc;
using AlunosMVC.Models;
namespace AlunosMVC.Controllers;
public class AlunoController : Controller
{
    private List<Aluno> alunos=new(){new(){Id=1,Nome="Ana Souza",Idade=17,Curso="Desenvolvimento de Sistemas"},new(){Id=2,Nome="Bruno Lima",Idade=18,Curso="Administração"},new(){Id=3,Nome="Carla Mendes",Idade=17,Curso="Desenvolvimento de Sistemas"},new(){Id=4,Nome="Daniel Alves",Idade=19,Curso="Mecânica"},new(){Id=5,Nome="Eduardo Brusco",Idade=17,Curso="Desenvolvimento de Sistemas"},new(){Id=6,Nome="Fernanda Costa",Idade=18,Curso="Eletricista"},new(){Id=7,Nome="Gabriel Santos",Idade=17,Curso="Administração"},new(){Id=8,Nome="Helena Martins",Idade=18,Curso="Desenvolvimento de Sistemas"}};
    public IActionResult Index()=>View(alunos);
    public IActionResult Detalhes(int id)=>View(alunos.FirstOrDefault(x=>x.Id==id));
}
