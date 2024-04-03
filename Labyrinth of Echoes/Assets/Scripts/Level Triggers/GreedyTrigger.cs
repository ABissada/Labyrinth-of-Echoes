using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreedyTrigger : MonoBehaviour
{
    
    public bool greedyFlag = false;

    private void greedyTrigger(Collider2D collision){
        if(collision.gameObject.name == "Greedy clone Variant"){
            greedyFlag = true;
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
