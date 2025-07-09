using System;
using System.Collections.Generic;

namespace SourcererSupreme.Designer.Data.Models
{
    public class Form
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public Project Project { get; set; } = null!;
        public List<FormControl> Controls { get; set; } = new();
    }
}
