public class Tweet {
    public int id;
    public int time;

    public Tweet(int _id, int _time) {
        id = _id;
        time = _time;
    }
}

public class Twitter {
    int time;
    Dictionary<int, HashSet<int>> userFollows;
    Dictionary<int, List<Tweet>> tweets;

    public Twitter() {
        time = 0;
        userFollows = new Dictionary<int, HashSet<int>>();
        tweets = new Dictionary<int, List<Tweet>>();
    }
    
    public void PostTweet(int userId, int tweetId) {
        InitializeUser(userId);
        Tweet tweet = new Tweet(tweetId, time++);
        tweets[userId].Add(tweet);
    }
    
    public List<int> GetNewsFeed(int userId) {
        var feed = new List<Tweet>(tweets.GetValueOrDefault(userId, new List<Tweet>()));

        foreach (var followeeId in userFollows.GetValueOrDefault(userId, new HashSet<int>())) {
            feed.AddRange(tweets.GetValueOrDefault(followeeId, new List<Tweet>()));
        }

        feed.Sort((a,b) => b.time - a.time);

        var res = new List<int>();
        for (int i = 0; i < Math.Min(10, feed.Count); i++) {
            res.Add(feed[i].id);
        }
        return res;
    }
    
    public void Follow(int followerId, int followeeId) {
        if (followerId != followeeId) {
            if (!userFollows.ContainsKey(followerId)) {
                userFollows[followerId] = new HashSet<int>();
            }
            userFollows[followerId].Add(followeeId);
        }
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if (userFollows.ContainsKey(followerId)) {
            userFollows[followerId].Remove(followeeId);
        }
    }

    private void InitializeUser(int userId) {
        if (!tweets.ContainsKey(userId)) {
            tweets[userId] = new List<Tweet>();
        }
    }
}
