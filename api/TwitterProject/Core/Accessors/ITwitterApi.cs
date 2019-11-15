using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Accessors
{
    public interface ITwitterApi
    {
        List<TweetObject> RetrieveTweets(string userName, int numTweets, string userAccessSecret, string consumerSecret);
    }
}
