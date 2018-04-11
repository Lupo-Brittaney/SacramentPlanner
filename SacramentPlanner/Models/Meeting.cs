using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
    
        public int ID { get; set; }

        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM d, yyyy}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Display(Name = "Conducting")]
        public string Conduct { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Opening Song")]
        public string OpenSong { get; set; }

        
        [Display(Name = "Opening Song #")]
        public int OpenSongNum { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Sacrament Song")]
        public string SacSong { get; set; }

        
        [Display(Name = "Sacrament Song #")]
        public int SacSongNum { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Closing Song")]
        public string CloseSong { get; set; }

        
        [Display(Name = "Closing Song #")]
        public int CloseSongNum { get; set; }

        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Display(Name = "Youth Speaker")]
        public string YouthSpeaker { get; set; }

        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Display(Name = "Youth Topic")]
        public string YouthTopic { get; set; }

        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Display(Name = "Second Speaker")]
        public string SecondSpeaker { get; set; }

        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Display(Name = "Second Speaker Topic")]
        public string SecondTopic { get; set; }

        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Display(Name = "Third Speaker")]
        public string ThirdSpeaker { get; set; }

        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Display(Name = "Third Speaker Topic")]
        public string ThirdTopic { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Display(Name = "Opening Prayer")]
        public string OpenPrayer { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Display(Name = "Closing Prayer")]
        public string ClosePrayer { get; set; }

    }

}
