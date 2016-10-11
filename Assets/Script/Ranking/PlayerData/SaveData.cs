using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
public class SaveData {

    private const string dataKey = "savedatakey";

    private static SaveData instance;

    public static SaveData Data
    {
        get
        {
            if (instance == null) instance = new SaveData();
            instance.Load();
            return instance;
        }
    }

    private PlayData current;
    public PlayData Current { get { return current; } }

    public List<PlayData> playDataList = new List<PlayData>();

    public void CreateNewPlayer(string name) {
        current = new PlayData(name);
    }

    public void SetPlayerScore(float  time, float diff, int point) {
        current.SetData(time, diff, point);
        if (playDataList == null)
            playDataList = new List<PlayData>();
        playDataList.Add(current);
        Save();
        Debug.Log(playDataList.Count);
    }

    public void Save() {
        var json = JsonConvert.SerializeObject(playDataList);
        PlayerPrefs.SetString(dataKey, json);
    }

    public void Load() {
        var json = PlayerPrefs.GetString(dataKey, "");
        playDataList = JsonConvert.DeserializeObject<List<PlayData>>(json);
    }
}
