using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GlobalTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public SceneTrigger[] SceneTriggers; 
    public int sceneIndex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int amount = 0;
        for(int i = 0; i < SceneTriggers.Length; i++){
            if(SceneTriggers[i].flag == true){
                amount++;
            }


        }
        if(amount == SceneTriggers.Length){
            SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
        }

    }
}
