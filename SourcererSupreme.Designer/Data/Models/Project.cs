﻿namespace SourcererSupreme.Designer.Data.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public List<Form> Forms { get; set; } = new();
    }
}
