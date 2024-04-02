namespace Pokemon_review_App.Models
{
    public class PokemonCategory
    {
        // represents a join table, a many to many relationship between the pokemon and category tables
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }

        public Pokemon pokemon { get; set; }
        public Category category { get; set; }
    }
}
