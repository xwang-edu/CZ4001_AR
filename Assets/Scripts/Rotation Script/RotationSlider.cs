using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationSlider : MonoBehaviour
{

    private GameObject sliderGameObject;
    private Slider rotateSlider;
    private GameObject stopPlacingButton;

    public bool x;
    public bool z;
    public float rotMinValue;
    public float rotMaxValue;
    public bool canRotate=true;

    void Start()
    {
        sliderGameObject = GameObject.Find("RotateSlider");
        sliderGameObject.SetActive(true);
        rotateSlider = sliderGameObject.GetComponent<Slider>();
        rotateSlider.minValue = rotMinValue;
        rotateSlider.maxValue = rotMaxValue;
        rotateSlider.onValueChanged.AddListener(RotateSliderUpdate);
        GameObject tick = GameObject.FindWithTag("StopPlacing");
        if(transform.name.Contains(tick.name)){
            stopPlacingButton = tick;
        }

        
    }

    void RotateSliderUpdate(float value){
        if(canRotate){
            if(x){
                transform.localEulerAngles = new Vector3(value,transform.rotation.y,transform.rotation.z);
            }
            else if (z){
                transform.localEulerAngles = new Vector3(transform.rotation.x,transform.rotation.y,value);
            }
            else{
                transform.localEulerAngles = new Vector3(transform.rotation.x,value,transform.rotation.z);
            }


        }
    }

    void Update(){
        if(stopPlacingButton.activeSelf){
            canRotate = true;
            (transform.gameObject.GetComponent("LeanPinchScale") as MonoBehaviour).enabled = true; 
        }
        else{
            (transform.gameObject.GetComponent("LeanPinchScale") as MonoBehaviour).enabled = false; 
            canRotate = false;
        }
    }
}
