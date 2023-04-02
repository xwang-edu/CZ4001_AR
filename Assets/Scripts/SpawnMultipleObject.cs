using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]

public class SpawnMultipleObject : MonoBehaviour
{

    
    private ARRaycastManager _arRaycastManger;
    private GameObject spawnedObject;
    private List<GameObject> placedPrefabList = new List<GameObject>();

    [SerializeField]
    private int maxPrefabSpawnCount = 0;
    private int placedPrefabCount;

    [SerializeField]
    private GameObject placeablePrefab;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();


    private void Awake(){
        _arRaycastManger = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPosition(out Vector2 touchPosition){
        if(Input.GetTouch(0).phase == TouchPhase.Began){
            touchPosition = Input.GetTouch(0).position;
            return true;
        }
        touchPosition = default;
        return false;
    }



    
    // Update is called once per frame
    void Update()
    {
        if(!TryGetTouchPosition(out Vector2 touchPosition)){
            return;
        }

        if(_arRaycastManger.Raycast(touchPosition,hits,TrackableType.PlaneWithinPolygon)){
            var hitPose = hits[0].pose;

            if(placedPrefabCount<maxPrefabSpawnCount){
                    
                    if(placedPrefabList.Contains(placeablePrefab)){
                        GameObject spawned = placedPrefabList.Find(obj=>obj.name==placeablePrefab.name);
                        spawned.transform.position = hitPose.position;
                        spawned.transform.rotation = hitPose.rotation;
                    }
                    else{
                        SpawnPrefab(hitPose);
                    }
                    
                    
                }
        }

    }

    public void SetPrefabType(GameObject prefabType){
        placeablePrefab = prefabType;
    }

    private void SpawnPrefab(Pose hitPose){
        spawnedObject = Instantiate(placeablePrefab,hitPose.position,hitPose.rotation);
        placedPrefabList.Add(spawnedObject);
        placedPrefabCount++;
    }
}
