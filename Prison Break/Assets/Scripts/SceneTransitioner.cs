using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitioner : MonoBehaviour
{
    public string scene;

    void OnTriggerEnter(Collider collider){
        if(collider.tag == "Player"){
            SceneManager.LoadSceneAsync(scene);
        }
    }
}
