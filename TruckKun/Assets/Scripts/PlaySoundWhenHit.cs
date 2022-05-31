using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundWhenHit : MonoBehaviour
{
    public AudioClip soundHit;

    void Start() {
        GetComponent<AudioSource>().clip = soundHit;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Player Hit " + other + "Playing Sound.");
            AudioSource.PlayClipAtPoint(soundHit, other.ClosestPoint(other.transform.position));
        }
    }
}
