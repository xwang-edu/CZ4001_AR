using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]

public class TapToPlaceTree : MonoBehaviour
{
    private bool canPlace = false;
    public GameObject gameObjectToInstantiate;
    private GameObject spawnedObject;
    public GameObject button;
    private ARRaycastManager _arRaycastManger;
    private Vector2 touchPosition;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();


    private void Awake(){
        _arRaycastManger = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPosition(out Vector2 touchPosition){
        if(Input.touchCount>0){
            touchPosition = Input.GetTouch(0).position;
            return true;
        }
        touchPosition = default;
        return false;
    }

    public void stopPlace(){
        canPlace = false;
        button.SetActive(false);
    }


    public void Place(){
        canPlace = true;
        button.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {   
        if(canPlace){
            if(!TryGetTouchPosition(out Vector2 touchPosition)){
                return;
            }

            if(_arRaycastManger.Raycast(touchPosition,hits,TrackableType.PlaneWithinPolygon)){
                var hitPose = hits[0].pose;

                if(spawnedObject == null){
                    spawnedObject = Instantiate(gameObjectToInstantiate,hitPose.position,hitPose.rotation);

                }
                else{
                    spawnedObject.transform.position = hitPose.position;
                    spawnedObject.transform.rotation = hitPose.rotation;
                }
            }
        }
        

    }
}