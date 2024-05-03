// MAINLY FOR IF YOU WANT A BUTTON TO DISPLAY SHII, YOU WILL NEED SIMPLE FILE BROWSER TO USE THIS BTW
using UnityEngine;
using UnityEngine.UI;
using System;
using SimpleFileBrowser;

public class SongLoaderButton : MonoBehaviour
{
    public SongLoader songLoader;
    public Text songNameText;
    public Text songBPMText;
    public Text songP1Text;
    public Text songP2Text;

    public void OnButtonClick()
    {
        FileBrowser.ShowLoadDialog((string[] paths) => {
            if (paths.Length > 0)
            {
                string jsonFilePath = paths[0];
                SongData songData = songLoader.LoadSongData(jsonFilePath);
                if (songData != null)
                {
                    songNameText.text = "Song: " + songData.song.song;
                    songBPMText.text = "BPM: " + songData.bpm;
                    songP1Text.text = "Player 1: " + songData.song.player1;
                    songP2Text.text = "Player 2: " + songData.song.player2;
                    Debug.Log("Song: " + songData.song.song + " BPM: " + songData.bpm + " P1: " + songData.song.player1 + " P2: " + songData.song.player2);
                }
            }
        }, null, false, null, "Select JSON File", "Select");
    }
}
