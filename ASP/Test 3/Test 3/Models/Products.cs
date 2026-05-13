namespace Test_3.Models
{
    //Tester med bøker
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public int author_id { get; set; }
        public int published_year { get; set; }
        public DateTime created_at { get; set; }

        public Product(int id_, string title_, int author_id_, int published_year_, DateTime created_at_)
        {
            id = id_;
            title = title_;
            author_id = author_id_;
            published_year = published_year_;
            created_at = created_at_;
        }
    }
}
