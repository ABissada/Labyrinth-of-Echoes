using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class slow_clone_movement_refactored : player_movement_refactored {

    public override void callMove(float horizontal, float vertical){
        moveCount += 1;
        if (player_movement_refactored.movesX.Count > 1) {
            horizontal = player_movement_refactored.movesX.Peek();
            vertical = player_movement_refactored.movesY.Peek();
            move(horizontal, vertical);
            counter = 0;
            callable = false;
        }
    }
}