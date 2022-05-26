using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip WaterDropSound, RainSound , DoruSound, BGMSong, OuchSound;
    static AudioSource AudioSrc;


    // Start is called before the first frame update
    void Start()
    {
        WaterDropSound = Resources.Load<AudioClip>("WaterDrop");
        RainSound = Resources.Load<AudioClip>("Rain");
        DoruSound = Resources.Load<AudioClip>("Yoshisound");
        BGMSong = Resources.Load<AudioClip>("BG_song");
        OuchSound = Resources.Load<AudioClip>("Ouch");

        AudioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void Playsound(string clip)
    {
        switch (clip)
        {
            case "WaterDrop":
                AudioSrc.PlayOneShot(WaterDropSound);
                break;
            case "Rain":
                AudioSrc.PlayOneShot(RainSound);
                break;
            case "Yoshisound":
                AudioSrc.PlayOneShot(DoruSound);
                break;
            case "BG_song":
                AudioSrc.PlayOneShot(BGMSong);
                break;
            case "Ouch":
                AudioSrc.PlayOneShot(OuchSound);
                break;

        }
    }
}
