using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    internal class Spatify
    {
        public static void Test()
        {
            List<Music> Music = new List<Music>();
            Music.Add(new Music("Uranus", GenreMusic.rap, "PNL"));
            Music.Add(new Music("Dive by", GenreMusic.electro, "Train"));
            Music.Add(new Music("safe and sound ", GenreMusic.classique, "Capital cities"));
            Music.Add(new Music("GoosBumps", GenreMusic.Rock, "Travis Scoot"));

            DataBase dataBase = new DataBase(Music);
            dataBase.DisplayMusic("Uranus");
            /*List<Music> stockNewMusic =dataBase.GetMusic(GenreMusic.rap);*/

            /*
            for(int i = 0; i < stockNewMusic.Count; i++)
            {
                Console.WriteLine(stockNewMusic[i].Title);
            }
            */
           
            



        }
    }
}
