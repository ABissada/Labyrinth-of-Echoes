using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetLevelScript : MonoBehaviour
{
    public levelMenuConfig configFile;

    public void ChangeScene()
    {
        SceneManager.LoadScene(configFile.thisSceneID, LoadSceneMode.Single);
    }

}