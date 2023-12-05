using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spatify_wpf
{
    public class DataBase
    {
        public List<Music> Data { get; set; }
        public DataBase(List<Music> DataBase)
        {
            this.Data = DataBase;

        }

        public List<Music> GetMusic(GenreMusic Genre)
        {
            List<Music> DataResult = Data.Where(musicElement => musicElement.GenreMusic == Genre).ToList();
            return DataResult;
        }

        public void DisplayMusic(string search)
        {
            search= Console.ReadLine();
            List<Music> DataResult = Data.Where(musicElement => musicElement.Title == search).ToList();
            for(int i = 0; i < DataResult.Count; i++)
            {
                Music music = DataResult[i];
            }
        }
        

    }
}
