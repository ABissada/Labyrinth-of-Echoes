using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GlobalTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public SceneTrigger[] SceneTriggers; 
    public int gotoScene = 1;

    public int levelNum;

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
            SceneManager.LoadScene(gotoScene, LoadSceneMode.Single);
            if(PlayerPrefs.GetInt("currentLevel") < levelNum) { //badness
                PlayerPrefs.SetInt("currentLevel", PlayerPrefs.GetInt("currentLevel") + 1);
                PlayerPrefs.Save();
            }
        }

    }
}
