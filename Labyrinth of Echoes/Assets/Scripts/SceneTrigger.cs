using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrigger : MonoBehaviour
{

    public string character;

    public bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == character)
        {
            print("Hit Trigger");
            flag = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.name == character)
        {
            print("Hit Trigger");
            flag = false;
        }
    }


}
