using System.Collections.Generic;

namespace PokeApp.Models
{
    public class AllPokemonModel   
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<Results> results { get; set; }
    }

    public class Results
    {
        public string name { get; set; }
        public string imagem
        {
            get
            {
                return "https://img.pokemondb.net/artwork/" + name + ".jpg";
            }
        }
    }
}
