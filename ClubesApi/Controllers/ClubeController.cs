using ClubesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ClubesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClubeController : ControllerBase
{
    private static int id = 1;                  //Começamos nosso id em Um.
    private static List<Clube> clubes = new List<Clube>();      //Criando a lista de clubes 

    [HttpPost]                                                  //Post pois adicionaremos um clube
    public void adicionaClube([FromBody] Clube clube)
    {
        clube.Id = id++;
        clubes.Add(clube);                                     //Adicionando clube a uma lista de clubes

    }

    [HttpGet]
    public IEnumerable<Clube> LeClubes([FromQuery] int skip = 0, [FromQuery] int take = 50)             //Recuperando um IEnumeravel de clubes com todos os clubes cadastrados, e adicionando o conceito de paginação com o método Skip e Take
    {
        return clubes.Skip(skip).Take(take);                                                        
    }

    [HttpGet("{id}")]                                                //Para nosso sistema saber diferenciar a ação GET aplicaremos como parametro o ID;
    public Clube? LeClubePorId(int id)                              //Esse ponto de Interrogação (?)´diz respeito pois o clube pode ser nulo.
    {
        return clubes.FirstOrDefault(clube => clube.Id == id);     // para cada elemento da lista clubes, vou verificar se o Id é igual ao Id recebido.
    }

}