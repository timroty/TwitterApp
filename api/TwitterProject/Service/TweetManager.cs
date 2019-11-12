using System.Collections.Generic;
using Core.Accessors;
using Core.Managers;

namespace Service
{
    public class TweetManager: ITweetManager
    {
        private readonly ITwitterApi _twitterApi;


        public TweetManager(ITwitterApi twitterApi)
        {
            _twitterApi = twitterApi;
        }

        public IEnumerable<string> SelectTweets(string userName, int numTweets, string userAccessSecret, string consumerSecret)
        {
            return _twitterApi.RetrieveTweets(userName, numTweets, userAccessSecret, consumerSecret);
        }
    }
}
