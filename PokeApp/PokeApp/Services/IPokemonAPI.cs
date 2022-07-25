using System;
using System.Collections.Generic;
using System.Text;
using Refit;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PokeApp.Services
{
    public  interface IPokemonAPI
    {
        [Get("/pokemon/{name}")]
        Task GetPokemonAsync(Entry entry_pokemon);
    }
}
