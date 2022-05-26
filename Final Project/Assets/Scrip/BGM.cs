using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "BGM")
        {
            SoundManager.Playsound("Rain");
            Destroy(gameObject);
        }
        if (collisionInfo.collider.tag == "Mainmenu")
        {
            SoundManager.Playsound("BG_song");
            Destroy(gameObject);
        }
    }
}