using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSound : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip bgm;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();

        audiosource.clip = bgm;

        audiosource.volume = 0.2f;
        audiosource.mute = false;
        audiosource.loop = true;
        audiosource.playOnAwake = true;
        audiosource.priority = 0;

        audiosource.Play();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.player_health <= 0)
        {
            audiosource.Stop();
        }
    }
}
