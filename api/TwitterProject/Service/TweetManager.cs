using System.Collections.Generic;
using Core.Accessors;
using Core.Engines;
using Core.Managers;
using Core.Models;

namespace Service
{
    public class TweetManager: ITweetManager
    {
        private readonly ITwitterApi _twitterApi;
        private readonly ITweetEngine _tweetEngine;


        public TweetManager(ITwitterApi twitterApi, ITweetEngine tweetEngine)
        {
            _twitterApi = twitterApi;
            _tweetEngine = tweetEngine;
        }

        public TweetInfo SelectTweets(string userName, int numTweets, string userAccessSecret, string consumerSecret)
        {
            var tweets = _twitterApi.RetrieveTweets(userName, numTweets, userAccessSecret, consumerSecret);
            var avgFavories = _tweetEngine.CalculateAvgFavorites(tweets);
            var avgRetweets = _tweetEngine.CalculateAvgRetweets(tweets);

            var tweetInfo = new TweetInfo
            {
                Tweets = tweets,
                AvgFavorites = avgFavories,
                AvgRetweets = avgRetweets
            };
            return tweetInfo;
        }



    }
}
