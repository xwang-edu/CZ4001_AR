using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateFloorScroll : MonoBehaviour
{
    public GameObject floorScroll;

    public void activateFloor(){
        floorScroll.SetActive(true);
    }
    public void deactivateFloor(){
        floorScroll.SetActive(false);
    }
}
