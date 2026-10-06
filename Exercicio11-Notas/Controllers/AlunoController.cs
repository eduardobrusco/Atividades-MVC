using Microsoft.AspNetCore.Mvc;
using NotasMVC.Models;
namespace NotasMVC.Controllers;
public class AlunoController : Controller
{
    private List<Aluno> alunos=new(){new(){Id=1,Nome="Ana",Curso="DS",Nota1=8,Nota2=7,Nota3=9},new(){Id=2,Nome="Bruno",Curso="DS",Nota1=5,Nota2=6,Nota3=5},new(){Id=3,Nome="Carla",Curso="ADM",Nota1=3,Nota2=4,Nota3=3},new(){Id=4,Nome="Daniel",Curso="Mecânica",Nota1=9,Nota2=8,Nota3=10},new(){Id=5,Nome="Eduardo",Curso="DS",Nota1=6,Nota2=6,Nota3=6},new(){Id=6,Nome="Fernanda",Curso="ADM",Nota1=4,Nota2=5,Nota3=4},new(){Id=7,Nome="Gabriel",Curso="DS",Nota1=2,Nota2=3,Nota3=3},new(){Id=8,Nome="Helena",Curso="Eletricista",Nota1=7,Nota2=8,Nota3=7},new(){Id=9,Nome="Igor",Curso="DS",Nota1=5,Nota2=5,Nota3=4},new(){Id=10,Nome="Julia",Curso="ADM",Nota1=10,Nota2=9,Nota3=9}};
    double M(Aluno a)=>(a.Nota1+a.Nota2+a.Nota3)/3;
    public IActionResult Index()=>View(alunos);
    public IActionResult Aprovados()=>View("Aprovados",alunos.Where(a=>M(a)>=6).ToList());
    public IActionResult Recuperacao()=>View("Recuperacao",alunos.Where(a=>M(a)>=4&&M(a)<6).ToList());
    public IActionResult Reprovados()=>View("Reprovados",alunos.Where(a=>M(a)<4).ToList());
}
