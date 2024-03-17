using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class horizontal_clone_movement_refactored : player_movement_refactored {


    public override void callMove(float horizontal, float vertical){
        move(horizontal*-1, vertical);
        counter = 0;
        callable = false;
    }
}