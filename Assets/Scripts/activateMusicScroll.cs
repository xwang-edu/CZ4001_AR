using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateMusicScroll : MonoBehaviour
{
    public GameObject musicScroll;

    public void activateMusic(){
        musicScroll.SetActive(true);
    }
    public void deactivateMusic(){
        musicScroll.SetActive(false);
    }
}
