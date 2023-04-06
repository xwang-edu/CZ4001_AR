using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;

    public void takeScreenshot(){
        canvas1.SetActive(false);
        canvas2.SetActive(true);
    }
}
