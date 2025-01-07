namespace Project.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Web> Webs { get; set; } // רשימה של אתרים בקטגוריה
    }
}
