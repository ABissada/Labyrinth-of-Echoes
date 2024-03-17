using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class remaining_moves : MonoBehaviour
{
    public int max_moves;

    public player_movement_refactored P;

    public bool outOfMoves;

    public TextMeshProUGUI moves_remaining;

    // Start is called before the first frame update
    void Start()
    {
        outOfMoves = false;
        P = FindObjectOfType<player_movement_refactored>();
        moves_remaining.SetText(max_moves.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        moves_remaining.SetText((max_moves - P.moveCount).ToString());
        if (max_moves - P.moveCount <= 0)
        {
            P.counter = 0;
        }

    }
}
