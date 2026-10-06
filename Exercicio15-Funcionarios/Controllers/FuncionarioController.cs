using Microsoft.AspNetCore.Mvc;
using FuncionariosMVC.Models;
namespace FuncionariosMVC.Controllers;
public class FuncionarioController : Controller
{
    private List<Funcionario> funcionarios=new(){new(){Id=1,Nome="Ana Souza",Cargo="Analista",Departamento="TI",Salario=5200,Ativo=true},new(){Id=2,Nome="Bruno Lima",Cargo="Assistente",Departamento="RH",Salario=2300,Ativo=true},new(){Id=3,Nome="Carla Mendes",Cargo="Desenvolvedora",Departamento="TI",Salario=6500,Ativo=true},new(){Id=4,Nome="Daniel Alves",Cargo="Gerente",Departamento="Financeiro",Salario=8000,Ativo=true},new(){Id=5,Nome="Eduardo Brusco",Cargo="Estagiário",Departamento="TI",Salario=1800,Ativo=true},new(){Id=6,Nome="Fernanda Costa",Cargo="Analista",Departamento="RH",Salario=4200,Ativo=false},new(){Id=7,Nome="Gabriel Santos",Cargo="Técnico",Departamento="Produção",Salario=3100,Ativo=true},new(){Id=8,Nome="Helena Martins",Cargo="Coordenadora",Departamento="RH",Salario=5600,Ativo=true},new(){Id=9,Nome="Igor Silva",Cargo="Auxiliar",Departamento="Financeiro",Salario=2400,Ativo=false},new(){Id=10,Nome="Julia Ramos",Cargo="Desenvolvedora",Departamento="TI",Salario=7200,Ativo=true},new(){Id=11,Nome="Lucas Oliveira",Cargo="Técnico",Departamento="Produção",Salario=2900,Ativo=true},new(){Id=12,Nome="Mariana Costa",Cargo="Analista",Departamento="Financeiro",Salario=4800,Ativo=true},new(){Id=13,Nome="Nicolas Souza",Cargo="Auxiliar",Departamento="Produção",Salario=2200,Ativo=false},new(){Id=14,Nome="Paula Lima",Cargo="Gerente",Departamento="TI",Salario=9500,Ativo=true},new(){Id=15,Nome="Rafael Alves",Cargo="Assistente",Departamento="RH",Salario=2600,Ativo=false}};
    public IActionResult Index()=>View(funcionarios);
    public IActionResult Ativos()=>View("Ativos",funcionarios.Where(x=>x.Ativo).ToList());
    public IActionResult Inativos()=>View("Inativos",funcionarios.Where(x=>!x.Ativo).ToList());
    public IActionResult Departamento(string nome="TI")=>View("Index",funcionarios.Where(x=>x.Departamento.Equals(nome,StringComparison.OrdinalIgnoreCase)).ToList());
    public IActionResult Dashboard()=>View(funcionarios);
}
