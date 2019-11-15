using System.Web.Http;
using Core;
using Core.Managers;
using Core.Models;
using Service;

namespace Web.Controllers
{
    public class TweetController : ApiController
    {
        private readonly ITweetManager _tweetManager;

        public TweetController(ITweetManager tweetManager)
        {
            _tweetManager = tweetManager;
        }

        [Route("Tweet/getTweets")]
        public TweetInfo Get(string userName, int numTweets, string userAccessSecret, string consumerSecret)
        {
            return _tweetManager.SelectTweets(userName, numTweets, userAccessSecret,
                consumerSecret);
        }

    }
}
