public class Stamp {
    public int timestamp;
    public string value;

    public Stamp(int timestamp, string value)
    {
        this.timestamp = timestamp;
        this.value = value;
    }
}

public class TimeMap {
    Dictionary<string, List<Stamp>> timeMap;

    public TimeMap() {
        timeMap = new Dictionary<string, List<Stamp>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!timeMap.ContainsKey(key)) {
            timeMap.Add(key, new List<Stamp>());
        }

        Stamp stamp = new Stamp(timestamp, value);
        timeMap[key].Add(stamp);
    }
    
    public string Get(string key, int timestamp) {
        if (!timeMap.ContainsKey(key))
            return "";

        var stampList = timeMap[key];

        if (stampList.Count == 0)
            return "";

        return FindTimeStamp(stampList, timestamp);
    }

    private string FindTimeStamp(List<Stamp> stampList, int timestamp) {
        int l = 0, r = stampList.Count - 1;
        int m;
        string res = "";

        while (l <= r) {
            m = l + (r - l) / 2;
            var stamp = stampList[m];

            Console.WriteLine($"l: {l} m: {m} r:{r}");

            if (stamp.timestamp == timestamp) {
                res = stamp.value;
                break;
            }
            else if (stamp.timestamp < timestamp) {
                res = stamp.value;
                l = m + 1;
            }
            else if (stamp.timestamp > timestamp){
                r = m - 1;
            }
        }

        return res;
    }
}
