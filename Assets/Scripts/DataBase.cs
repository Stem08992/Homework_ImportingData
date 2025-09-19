using System.Collections.Generic;
using UnityEngine;


public class DataBase : MonoBehaviour {
    public List<LevelInfo> levels = new List<LevelInfo>();

    public void ReadData() {
        // Gets the Json from Resource Folder
        TextAsset jsonFile = Resources.Load<TextAsset>("data"); // no .json extension
        // Reads the JSON
        LevelInfoDatabase levelInfoDatabase = JsonUtility.FromJson<LevelInfoDatabase>(jsonFile.text);

        // Uses the broken JSON data to collect the text and int values as well as connect to the
        // appropriate image in Resource Folder
        foreach (var t in levelInfoDatabase.levelInfo) {
            levels.Add(new LevelInfo(t,
                Resources.Load<Sprite>("Sprites/" + t.ImageName)));
        }
    }
}
