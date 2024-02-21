using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_collections
{
    public class Film
    {
        public string titre;
        public List<string> actor = new List<string>();

        public Film(string titre, string[] actor)
        {
            this.titre = titre;
            this.actor.AddRange(actor);
        }
    }
}
