using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteButton : MonoBehaviour
{
    public GameObject _muteButton;
    public GameObject music;
    public void activateMuteButton(){
        _muteButton.SetActive(true);
    }

    public void deactivateMuteButton(){
        _muteButton.SetActive(false);
        music.SetActive(false);
    }

}
