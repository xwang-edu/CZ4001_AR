using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// todo: load different set of filters & objects with the buttons
public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
