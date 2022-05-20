using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySound : MonoBehaviour
{
    public AudioClip voiceClip;
    public AudioClip zzzClip;
    public void PlayVoice() {
        GetComponent<AudioSource>().PlayOneShot(voiceClip);
    }

    public void PlayZZZ() {
        GetComponent<AudioSource>().PlayOneShot(zzzClip);
    }
}
