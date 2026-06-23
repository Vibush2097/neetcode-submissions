public class TimeMap {
    Dictionary<string, List<(string, int)>> timeMap;

    public TimeMap() {
        timeMap = new Dictionary<string, List<(string, int)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!timeMap.ContainsKey(key)) {
            timeMap[key] = new List<(string, int)>();
        }

        timeMap[key].Add((value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        if (!timeMap.ContainsKey(key)) {
            return "";
        }

        var values = timeMap[key];
        int l = 0, r = values.Count - 1, m;
        int ans = -1;

        while (l <= r) {
            m = l + (r - l) / 2;
            int time = values[m].Item2;

            if (time <= timestamp) {
                ans = m;
                l = m + 1;
            }
            else {
                r = m - 1;
            }
        }

        if (ans == -1) {
            return "";
        }

        return values[ans].Item1;
    }
}
