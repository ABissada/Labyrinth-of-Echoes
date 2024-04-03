using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalTrigger : MonoBehaviour
{
    
    public bool horizontalFlag = false;

    private void horizontalTrigger(Collider2D collision){
        if(collision.gameObject.name == "Horizontal clone Variant"){
            horizontalFlag = true;
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
