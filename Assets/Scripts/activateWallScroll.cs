using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateWallScroll : MonoBehaviour
{
    public GameObject wallScroll;

    public void activateWall(){
        wallScroll.SetActive(true);
    }
    public void deactivateWall(){
        wallScroll.SetActive(false);
    }
}
