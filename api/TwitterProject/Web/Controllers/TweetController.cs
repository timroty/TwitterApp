using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Core;
using Core.Managers;
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

        //[Route("Tweet/Get")]
        public IEnumerable<string> Get()
        {
            return _tweetManager.SelectTweets("tcroty", 10, "",
                "");
        }

        //[Route("Tweet/test")]
        public IEnumerable<string> Get(string userName, int numTweets, string userAccessSecret, string consumerSecret)
        {
            return _tweetManager.SelectTweets("tcroty", 10, userAccessSecret,
                consumerSecret);
        }

    }
}
