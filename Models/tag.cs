using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorTagNavigation.Models
{
    public class tag
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bootstrap_colors bg_color { get; set; } = bootstrap_colors.secondary;
        public bootstrap_colors text_color { get; set; } = bootstrap_colors.white;
        public DateTime date { get; set; }
    }
}
