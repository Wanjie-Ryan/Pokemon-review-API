﻿namespace Pokemon_review_App.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string name { get; set; }

        public ICollection<PokemonCategory> pokemonCategories { get; set; }
    }
}
