using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace spatify_wpf
{
    public class Music
    {
        public string Title { get; set; }
        public GenreMusic GenreMusic { get; set; }
        public string Artist { get; set; }


        public Music(string title, GenreMusic GenreMusic, string Artist) { 
            this.Title = title;
            this.GenreMusic = GenreMusic;
            this.Artist = Artist;
        }

    }
}
