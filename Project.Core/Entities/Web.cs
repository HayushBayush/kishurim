namespace Project.Entities
{
    public class Web
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }

        public int idCategory { get; set; }
        public Category Category { get; set; } // קשר לקטגוריה
    }
}
