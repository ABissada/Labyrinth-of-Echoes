using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    
    public bool playerFlag = false;

    private void playerTrigger(Collider2D collision){
        if(collision.gameObject.name == "player"){
            playerFlag = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
