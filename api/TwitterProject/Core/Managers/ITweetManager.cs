using Core.Models;

namespace Core.Managers
{
    public interface ITweetManager
    {
       TweetInfo SelectTweets(string userName, int numTweets, string userAccessSecret,
            string consumerSecret);
    }
}
