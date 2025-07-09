using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourcererSupreme.Generator.Models
{
    public class ProjectConfiguration
    {
        public string ProjectName { get; set; } = string.Empty;
        public List<FormConfiguration> Forms { get; set; } = new();
    }

    public class FormConfiguration
    {
        public string Name { get; set; } = string.Empty;
        public List<ControlConfiguration> Controls { get; set; } = new();
    }

    public class ControlConfiguration
    {
        public string Type { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Dictionary<string, object> Properties { get; set; } = new();
    }
}
