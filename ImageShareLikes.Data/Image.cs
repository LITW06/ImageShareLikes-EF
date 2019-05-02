using System;
using System.ComponentModel.DataAnnotations;

namespace ImageShareLikes.Data
{
    public class Image
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Required]
        public string FileName { get; set; }
        public DateTime DateUploaded { get; set; }
        public int Likes { get; set; }
        public bool? IsHighRes { get; set; }
    }
}
