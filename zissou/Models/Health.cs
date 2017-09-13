using System.Collections.Generic;
namespace zissou.Models
{              
    public class Health 
    { 
        public bool Healthy { get; set; }
        public List<Dependency> Dependencies { get; set; } 
    }
}