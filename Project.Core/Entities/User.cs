namespace Project.Entities
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Email { get; set; }
        public int PhoneNamber { get; set; }

        public List<Recommend> Recommends { get; set; } // רשימה של המלצות של המשתמש
    }
}
