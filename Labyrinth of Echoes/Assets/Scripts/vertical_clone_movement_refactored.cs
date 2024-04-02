using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class vertical_clone_movement_refactored : player_movement_refactored {


    public override void callMove(float horizontal, float vertical){
        moveCount += 1;
        move(horizontal, vertical*-1);
        counter = 0;
        callable = false;
    }
}