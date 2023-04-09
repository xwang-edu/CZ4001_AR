using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCanvas : MonoBehaviour
{
    public GameObject canvas;
    public GameObject canvas2;

    public void openBackCanvas(){
        canvas.SetActive(true);
    }

    public void closeCanvas2(){
        canvas2.SetActive(false);
    }
}
