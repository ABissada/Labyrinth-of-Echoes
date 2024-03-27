using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class remaining_moves : MonoBehaviour
{
    public levelMenuConfig config;

    public TextMeshProUGUI moves_remaining;

    private player_movement_refactored[] P;

    // Start is called before the first frame update
    void Start()
    {
        P = config.list_of_characters;
        moves_remaining.SetText(config.maxMoves.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i<P.Length; i++)
        {
            moves_remaining.SetText((config.maxMoves - P[i].moveCount).ToString());
            if (config.maxMoves - P[i].moveCount <= 0)
            {
                P[i].counter = 0;
            }
        }

    }
}
