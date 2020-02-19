using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webbaplication.Controllers
{
    [Produces("application/json")]
    [Route("api/Pokemon")]


    public class PokemonController : ControllerBase
    {
        public static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Ekans", Strength = 67 },
            new Pokemon() {Name = "Bulbasaur", Strength = 200},
            new Pokemon() {Name = "Eva-Lena", Strength = 9001}
        };




        [HttpGet]

        public ActionResult MyPerfectGet()
        {
            /*Pokemon p = new Pokemon();
            p.Name = "Ekans";
            p.Strength = 67;*/

            return Ok(pokemons);
        }


        [HttpPost]

        public ActionResult AddNewPokemon(Pokemon newPokemon)
        {
            pokemons.Add(newPokemon);
            Console.WriteLine("Added new Pokemon" + newPokemon);

            return Created("", newPokemon);



        }



    }
}