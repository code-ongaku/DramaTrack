using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DramaTrack
{
    public partial class KDrama
    {
        public string Name { get; set; }
        public int NumberOfEpisodes { get; set; }
        public int CompletedEpisodes { get; set; }
        public string Thoughts { get; set; }

        //pubcli void KDrama(string kName, int totalEps, int compEps)
        //{
        //    string Name = kName;
        //    int Total = totalEps;
        //    int Completed = compEps;
        //}
    }
}
