using System.Collections.Generic;

namespace Cars
{
    public class Producer
    {
        public string Name { get; set; }

        public IEnumerable<Model> Models { get; set; }
    }
}
