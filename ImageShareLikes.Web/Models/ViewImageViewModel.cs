using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageShareLikes.Data;

namespace ImageShareLikes.Web.Models
{
    public class ViewImageViewModel
    {
        public Image Image { get; set; }
        public bool CanLikeImage { get; set; }
    }
}
