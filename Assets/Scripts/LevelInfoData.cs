using System;
using UnityEngine;

[Serializable]
public class LevelInfo 
{
    public Sprite Sprite;
    public string Title;
    public int Str;
    public int Stm;
    public int Int;

    public LevelInfo(LevelInfoData data, Sprite sprite)
    {
        this.Sprite = sprite;
        this.Title = data.Title;
        this.Str = data.Str;
        this.Stm = data.Stm;
        this.Int = data.Int;
    }
}

[Serializable]
public class LevelInfoData
{
    public string ImageName;
    public string Title;
    public int Str;
    public int Stm;
    public int Int; 
}

[Serializable]
public class LevelInfoDatabase {
    public LevelInfoData[] levelInfo;
}
