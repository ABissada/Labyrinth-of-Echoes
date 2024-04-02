using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class greedy_clone_movement_refactored : player_movement_refactored {

    public override float moveSpeed { get; set; } = 6f;

    public override void callMove(float horizontal, float vertical){
        moveCount += 1;
        move(horizontal, vertical);
        move(horizontal, vertical);
        counter = 0;
        callable = false;
    }
}