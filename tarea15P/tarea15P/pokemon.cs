using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea15P
{
    internal class pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SpriteData Sprites { get; set; }
        public List<TypeData> Types { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
    }

    internal class SpriteData
    {
        public string Front_Default { get; set; }
        public string Front_Shiny { get; set; }
    }

    internal class TypeData
    {
        public TypeInfo Type { get; set; }
    }

    internal class TypeInfo
    {
        public string Name { get; set; }
    }
  

}
