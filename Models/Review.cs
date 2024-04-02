namespace Pokemon_review_App.Models
{
    public class Review
    {
        public int Reviewid { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public Reviewer reviewer { get; set; }
        public pokemon pokemon { get; set; }
    }
}
