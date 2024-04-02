namespace Pokemon_review_App.Models
{
    public class Pokemon
    {
        // THESE ACT LIKE OUR MODELS
        public int PokemonId { get; set; }
        public string name { get; set; }
        public DateTime birthDate { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<PokemonOwner> pokemonOwners { get; set; }
        public ICollection<PokemonCategory> pokemoncategory { get; set; }
    }
}
