namespace Pokemon_review_App.Models
{
    public class Owner
    {
        // THESE ACT LIKE OUR MODELS

        public int Ownerid { get; set; }
        public string name { get; set; }
        public string gym { get; set; }

        //
        public Country country { get; set; }

        public ICollection<PokemonOwner> pokemonOwners { get; set; }
    }
}
