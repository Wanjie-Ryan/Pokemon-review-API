namespace Pokemon_review_App.Models
{
    public class PokemonOwner
    {
        // represents a join table, a many to many relationship between the pokemon and owner tables

        public int PokemonId { get; set; }
        public int OwnerId { get; set; }

        public Pokemon pokemon { get; set; }

        public Owner owner { get; set; }
    }
}
