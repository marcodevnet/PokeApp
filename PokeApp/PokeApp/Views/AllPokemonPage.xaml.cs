﻿using PokeApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllPokemonPage : ContentPage
    {
        AllPokemonViewModel allPokemonVM;
        public AllPokemonPage()
        {
            InitializeComponent();
            BindingContext = allPokemonVM = new AllPokemonViewModel();
        }
    }
}