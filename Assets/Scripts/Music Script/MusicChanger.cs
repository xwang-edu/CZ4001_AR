using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChanger : MonoBehaviour
{
  
    public AudioSource music;
    public AudioClip newClip;

    public void changeChip(){
        music.clip = newClip;
        music.Play();
    }
}
