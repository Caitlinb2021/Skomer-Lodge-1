using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class TVScript : MonoBehaviour
{
    public VideoPlayer player;
    public Button button;
    public Sprite startsprite;
    public Sprite stopsprite;

    public void Start()
    {
        player = GetComponent<VideoPlayer>();
    }

    public void TVStartStop()
    {
        if (player.isPlaying == false)
        {
            player.Play();
            button.image.sprite = stopsprite;
        }
        else
        {
            player.Pause();
            button.image.sprite = startsprite;
        }
    }

}
