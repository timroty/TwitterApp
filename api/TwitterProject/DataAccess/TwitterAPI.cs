using System.Collections.Generic;
using System.Linq;
using Tweetinvi;
using Core.Accessors;


namespace DataAccess
{
    public class TwitterApi : ITwitterApi
    { 
        public List<string> RetrieveTweets(string userName, int numTweets, string userAccessSecret, string consumerSecret)
        {
            Auth.SetUserCredentials("fQuu1iPvZjVTRnzVAjb9VLAav", consumerSecret, "2726847952-6dqKq1hnQTfZfSc7jsDFg3jbdRs1SLULyc6vQ6r", userAccessSecret);
            var user = User.GetUserFromScreenName(userName);
            var tweets = Timeline.GetUserTimeline(user, numTweets).ToList();

            return tweets.Select(tweet => tweet.Text).ToList();
        }
    }
}
