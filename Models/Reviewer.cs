namespace Pokemon_review_App.Models
{
    public class Reviewer
    {
        public int Reviewerid { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        // an ICollection is sort of a list but it is not editable, used in a one to many relationship
        public ICollection<Review> reviews { get; set; }
    }
}
