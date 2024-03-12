using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    public float moveSpeed = 3f;
    public Transform playerMovePoint;

    public LayerMask whatStopsMovement;

    public SpriteRenderer sr;

    public int moveCount = 0;



    // Start is called before the first frame update
    void Start()
    {
        playerMovePoint.parent = null;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerMovePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, playerMovePoint.position) == 0f) {

            if (Input.GetAxisRaw("Horizontal") == -1f) {
                moveCount += 1;
                sr.flipX = true;
                if(!Physics2D.OverlapCircle(playerMovePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), 0.2f, whatStopsMovement)) {
                    playerMovePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }

            else if (Input.GetAxisRaw("Horizontal") == 1f) {
                moveCount += 1;
                sr.flipX = false;
                if(!Physics2D.OverlapCircle(playerMovePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), 0.2f, whatStopsMovement)) {
                    playerMovePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }

            else if (Math.Abs(Input.GetAxisRaw("Vertical")) == 1f) {
                moveCount += 1;
                if(!Physics2D.OverlapCircle(playerMovePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), 0.2f, whatStopsMovement)) {
                    playerMovePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }
        }
    }
}
