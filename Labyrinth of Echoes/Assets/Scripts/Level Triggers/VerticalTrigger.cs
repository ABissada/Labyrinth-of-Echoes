using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalTrigger : MonoBehaviour
{
    
    public bool verticalFlag = false;

    private void verticalTrigger(Collider2D collision){
        if(collision.gameObject.name == "Vertical clone Variant"){
            verticalFlag = true;
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
