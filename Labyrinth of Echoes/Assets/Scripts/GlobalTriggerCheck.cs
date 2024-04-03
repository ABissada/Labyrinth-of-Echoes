using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GlobalTriggerCheck : MonoBehaviour
{
    
    public int sceneIndex;
    public HorizontalTrigger horizontal;
    public VerticalTrigger vertical;
    public SlowTrigger slow;
    public GreedyTrigger greedy;
    public PlayerTrigger player;
    public string[] triggers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(triggers.Length == 1){
            if(triggers[0] == "player"){
                player = FindObjectOfType<PlayerTrigger>();
                if(player.playerFlag == true){
                    print("Hit Trigger");
                    SceneManager.LoadScene(sceneIndex,LoadSceneMode.Single);
                }   
            }
        }
        else if(triggers.Length == 2){
            if(triggers[0] == "player" && triggers[1] == "horizontal"){
                horizontal = FindObjectOfType<HorizontalTrigger>();
                player = FindObjectOfType<PlayerTrigger>();
                if(horizontal.horizontalFlag == true && player.playerFlag == true){
                    print("Hit Trigger");
                    SceneManager.LoadScene(sceneIndex,LoadSceneMode.Single);
                }
            }
            if(triggers[0] == "player" && triggers[1] == "vertical"){
                vertical = FindObjectOfType<VerticalTrigger>();
                player = FindObjectOfType<PlayerTrigger>();
                if(vertical.verticalFlag == true && player.playerFlag == true){
                    print("Hit Trigger");
                    SceneManager.LoadScene(sceneIndex,LoadSceneMode.Single);
                }
            }
            if(triggers[0] == "player"&& triggers[1] == "greedy"){
                greedy = FindObjectOfType<GreedyTrigger>();
                player = FindObjectOfType<PlayerTrigger>();
                if(greedy.greedyFlag == true && player.playerFlag == true){
                    print("Hit Trigger");
                    SceneManager.LoadScene(sceneIndex,LoadSceneMode.Single);
                }
            }
            if(triggers[0] == "player" && triggers[1] == "slow"){
                slow = FindObjectOfType<SlowTrigger>();
                player = FindObjectOfType<PlayerTrigger>();
                if(slow.slowFlag == true && player.playerFlag == true){
                    print("Hit Trigger");
                    SceneManager.LoadScene(sceneIndex,LoadSceneMode.Single);
                }
            }
        }
        else if(triggers.Length == 3){
            if((triggers[0] == "player" && triggers[1] == "horizontal" && triggers[2] == "vertical") || (triggers[0] == "player" && triggers[1] == "vertical" && triggers[2] == "horizontal")){
                horizontal = FindObjectOfType<HorizontalTrigger>();
                vertical = FindObjectOfType<VerticalTrigger>();
                player = FindObjectOfType<PlayerTrigger>();
                if(horizontal.horizontalFlag == true && player.playerFlag == true && vertical.verticalFlag == true){
                    print("Hit Trigger");
                    SceneManager.LoadScene(sceneIndex,LoadSceneMode.Single);
                }
            }
        }
    }
}
