using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Model
    {
        public string Name { get; set; }

        public EnumEngine TypeOfEngine { get; set; }

        public IEnumerable<EnumExtra> Extras { get; set; }
    }
}
