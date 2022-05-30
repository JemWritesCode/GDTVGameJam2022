using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundWhenHit : MonoBehaviour
{
    // todo: For when the truck hits the MC. Not working rn. The clip does work if it's set to "Play on Awake" but not like this? It does reach Hit Player so maybe using audio wrong

    public AudioClip soundHit;
    // Start is called before the first frame update

    void Start() {
        GetComponent<AudioSource>().clip = soundHit;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Hit!");
        if(other.tag == "Player")
        {
            //Debug.Log("Hit Player");
            GetComponent<AudioSource>().Play();
        }
    }
}
