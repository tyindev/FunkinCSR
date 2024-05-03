using UnityEngine;
using System.IO;

public class SongLoader : MonoBehaviour
{
    public SongData LoadSongData(string path)
    {
        if (!File.Exists(path))
        {
            Debug.LogError("File not found at path: " + path);
            return null;
        }
        string json = File.ReadAllText(path);
        SongData songData = JsonUtility.FromJson<SongData>(json);
        return songData;
    }
}

[System.Serializable]
public class SongData
{
    public string song;
    public int bpm;
    public float speed;
    public string player1;
    public string player2;
}
