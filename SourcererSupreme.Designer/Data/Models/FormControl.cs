namespace SourcererSupreme.Designer.Data.Models
{
    public class FormControl
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string Type { get; set; } = string.Empty; // "TextBox" or "Button"
        public string Name { get; set; } = string.Empty;
        public int X { get; set; }
        public int Y { get; set; }
        public string Properties { get; set; } = "{}"; // JSON serialized properties
        public Form Form { get; set; } = null!;
    }
}
