using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTrigger : MonoBehaviour
{
    
    public bool slowFlag = false;

    private void slowTrigger(Collider2D collision){
        if(collision.gameObject.name == "Slow clone Variant"){
            slowFlag = true;
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