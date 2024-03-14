using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PopUp : MonoBehaviour
{
    public bool movement = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.D))
        {
            movement = true;
            gameObject.SetActive(!movement);
        }
    }
}
