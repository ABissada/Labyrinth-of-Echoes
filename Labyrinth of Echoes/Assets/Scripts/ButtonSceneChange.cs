using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneChange : MonoBehaviour
{
    public int sceneIndex;

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }

}
