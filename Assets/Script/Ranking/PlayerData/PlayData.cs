using UnityEngine;
using System.Collections;
using Newtonsoft.Json;
public class PlayData {

    [JsonProperty]
    public string Name { get; private set; }
    [JsonProperty]
    public float Time { get; private set; }
    [JsonProperty]
    public float DifferenceTime { get; private set; }
    [JsonProperty]
    public int Point { get; private set; }

    public PlayData(string name)
    {
        Name = name;
    }

    public void SetData(float time, float diff, int point) {
        Time = time;
        DifferenceTime = diff;
        Point = point;
    }
}
