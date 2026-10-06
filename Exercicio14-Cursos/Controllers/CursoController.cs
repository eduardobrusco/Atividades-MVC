using Microsoft.AspNetCore.Mvc;
using CursosMVC.Models;
namespace CursosMVC.Controllers;
public class CursoController : Controller
{
    private List<Curso> cursos=new(){new(){Id=1,Nome="Desenvolvimento de Sistemas",CargaHoraria=1200,Modalidade="Presencial",Vagas=20,Valor=0},new(){Id=2,Nome="Python",CargaHoraria=80,Modalidade="Online",Vagas=15,Valor=500},new(){Id=3,Nome="Banco de Dados",CargaHoraria=80,Modalidade="Online",Vagas=0,Valor=450},new(){Id=4,Nome="C#",CargaHoraria=100,Modalidade="Presencial",Vagas=10,Valor=600},new(){Id=5,Nome="Excel",CargaHoraria=40,Modalidade="Online",Vagas=25,Valor=250},new(){Id=6,Nome="Redes",CargaHoraria=120,Modalidade="Presencial",Vagas=8,Valor=700},new(){Id=7,Nome="Web Design",CargaHoraria=80,Modalidade="Online",Vagas=0,Valor=400},new(){Id=8,Nome="Eletricista",CargaHoraria=160,Modalidade="Presencial",Vagas=12,Valor=900},new(){Id=9,Nome="Administração",CargaHoraria=800,Modalidade="Presencial",Vagas=0,Valor=1200},new(){Id=10,Nome="Inglês",CargaHoraria=100,Modalidade="Online",Vagas=30,Valor=350}};
    public IActionResult Index()=>View(cursos);
    public IActionResult Disponiveis()=>View("Index",cursos.Where(x=>x.Vagas>0).ToList());
    public IActionResult Online()=>View("Index",cursos.Where(x=>x.Modalidade=="Online").ToList());
    public IActionResult Presenciais()=>View("Index",cursos.Where(x=>x.Modalidade=="Presencial").ToList());
}
