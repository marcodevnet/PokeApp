using Newtonsoft.Json;
using PokeApp.Models;
using PokeApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PokeApp.ViewModels
{
    public class AllPokemonViewModel : HelperViewModel
    {
        public ObservableCollection<Results> ListPokemon { get; set; }
        public Command LoadingMore { get; }

        public Command ExitComand
        {
            get
            {
                return new Command(Exit);
            }
        }

        public AllPokemonViewModel()
        {
            ListPokemon = new ObservableCollection<Results>();
            FeedList();
        }

        public void FeedList()
        {
            ListPokemon = GetAllPokemons();
        }

        public async void ItemSelected(string pokemonName)
        {
            MessagingCenter.Send<string>(pokemonName, "Pokemon");
            await App.Current.MainPage.Navigation.PopAsync();
        }

        public ObservableCollection<Results> GetAllPokemons(int amountMorePokemon = 20)
        {
            var url = "https://pokeapi.co/api/v2/pokemon/?limit=151";

            using (var httpClient = new HttpClient())
            {
                try
                {
                    var content = httpClient.GetStringAsync(url).Result;

                    var returnConsult = JsonConvert.DeserializeObject<AllPokemonModel>(content);

                    return new ObservableCollection<Results>(returnConsult.results);
                }

                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    return new ObservableCollection<Results>();
                }
            }
        }

        private async void Exit()
        {
            var answer = await App.Current.MainPage.DisplayAlert("Salir", "¿Esta seguro que desea salir?", "Si", "No");
            if (answer)
            {
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
            }
            else
            {
                return;
            }
        }
    }
}
