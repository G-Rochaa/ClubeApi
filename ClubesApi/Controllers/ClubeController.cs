using ClubesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ClubesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClubeController : ControllerBase
{
    private static int id = 0;                  //Começamos nosso id em zero.
    private static List<Clube> clubes = new List<Clube>();      //Criando a lista de clubes 

    [HttpPost]                                                  //Post pois adicionaremos um clube
    public void adicionaClube([FromBody] Clube clube)
    {
        clube.Id = id++;
        clubes.Add(clube);                                     //Adicionando clube a uma lista de clubes

    }

    [HttpGet]
    public IEnumerable<Clube> LeClubes()                       //Recuperando um IEnumeravel de clubes com todos os clubes cadastrados
    {
        return clubes;
    }

    

  

}