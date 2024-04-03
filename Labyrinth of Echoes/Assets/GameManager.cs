using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public Button[] lvlButtons;

    void Awake() {
        Instance = this;
    }

    void Start() {
        int currentLevel = PlayerPrefs.GetInt("currentLevel", 0);

        for (int i = 0; i < lvlButtons.Length; i++) {
            if (i  > currentLevel) {
                lvlButtons[i].interactable = false;
            }
        }
    }
    
}
