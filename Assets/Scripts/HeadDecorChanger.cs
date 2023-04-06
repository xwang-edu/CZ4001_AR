using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARFaceManager))]

public class HeadDecorChanger:MonoBehaviour
{

    private ARFaceManager arFaceManager;


    [SerializeField]
    public FacePrefab[] prefabs;


    void Awake(){
        arFaceManager = GetComponent<ARFaceManager>();
        arFaceManager.facePrefab= prefabs[0].prefab;
    }

    public void changeHeadDecor(int sequence){
        arFaceManager.facePrefab = prefabs[sequence].prefab;
    }

    
    
}

[System.Serializable]
public class FacePrefab
{
    public GameObject prefab;
    public string Name;
}