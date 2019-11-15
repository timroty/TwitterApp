using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TweetObject
    {
        public string Text { get; set; }
        public int Retweets { get; set; }
        public int Favorites { get; set; }
    }
}
