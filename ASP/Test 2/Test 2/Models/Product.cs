namespace Test_2.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string medium { get; set; }
        public int published_year { get; set; }
        public DateTime created_at { get; set; }

        public Product(int id_, string name_, string medium_, int published_year_/*, DateTime created_at_*/)
        {
            id = id_;
            name = name_;
            medium = medium_;
            published_year = published_year_;
            /*created_at = created_at_;*/
        }
    }
}
