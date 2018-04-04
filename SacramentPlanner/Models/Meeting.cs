using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
    
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public string Conduct { get; set; }

        public string OpenSong { get; set; }

        public int OpenSongNum { get; set; }

        public string SacSong { get; set; }

        public int SacSongNum { get; set; }

        public string CloseSong { get; set; }

        public int CloseSongNum { get; set; }

        public string YouthSpeaker { get; set; }

        public string YouthTopic { get; set; }

        public string SecondSpeaker { get; set; }

        public string SecondTopic { get; set; }

        public string ThirdSpeaker { get; set; }

        public string ThirdTopic { get; set; }

        public string OpenPrayer { get; set; }

        public string ClosePrayer { get; set; }

    }

}
