using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnmuteButton : MonoBehaviour
{
    public GameObject unmuteButton;
    public GameObject music;
    public void activateUnmuteButton(){
        unmuteButton.SetActive(true);
    }

    public void deactivateUnmuteButton(){
        unmuteButton.SetActive(false);
        music.SetActive(true);
    }
  
}
