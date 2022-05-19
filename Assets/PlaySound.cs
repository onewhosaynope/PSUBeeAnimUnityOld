using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySound : MonoBehaviour
{
    public void PlyaVoice() {
        GetComponent<AudioSource>().Play();
    }
}
