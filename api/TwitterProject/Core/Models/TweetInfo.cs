using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TweetInfo
    {
        public List<TweetObject> Tweets { get; set; }
        public int AvgFavorites { get; set; }
        public int AvgRetweets { get; set; }
    }
}
