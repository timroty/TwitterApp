using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Engines;
using Core.Models;

namespace Service
{
    public class TweetEngine: ITweetEngine
    {
        public int CalculateAvgFavorites(List<TweetObject> tweets)
        {
            var sum = tweets.Sum(tweet => tweet.Favorites);

            var average = sum / tweets.Count();

            return average;
        }

        public int CalculateAvgRetweets(List<TweetObject> tweets)
        {
            var sum = tweets.Sum(tweet => tweet.Retweets);

            var average = sum / tweets.Count();

            return average;
        }
    }
}
