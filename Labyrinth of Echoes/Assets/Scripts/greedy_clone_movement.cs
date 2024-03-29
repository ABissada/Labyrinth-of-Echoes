using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greedy_clone_movement : MonoBehaviour
{

    public float moveSpeed = 6f;
    public Transform greedyMovePoint;

    public LayerMask whatStopsMovement;

    public SpriteRenderer sr;

    Stack<Vector3> moves = new Stack<Vector3>();


    // Start is called before the first frame update
    void Start()
    {
        greedyMovePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, greedyMovePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, greedyMovePoint.position) == 0f) {

            if (Input.GetKey(KeyCode.U) && moves.Count != 0) {
                greedyMovePoint.position = moves.Pop();
            }

            if (Input.GetAxisRaw("Horizontal") == -1f) {
                sr.flipX = true;
                for(int i = 0; i < 2; i++){
                    if(!Physics2D.OverlapCircle(greedyMovePoint.position +  (new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f)), 0.2f, whatStopsMovement)) {
                        greedyMovePoint.position += (new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f));
                        moves.Push(GameObject.Find("greedy clone").transform.position);
                    }
                }
            }

            else if (Input.GetAxisRaw("Horizontal") == 1f) {
                sr.flipX = false;
                for(int i = 0; i < 2; i++) {
                    if(!Physics2D.OverlapCircle(greedyMovePoint.position + (new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f)), 0.2f, whatStopsMovement)) {
                        greedyMovePoint.position += (new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f));
                        moves.Push(GameObject.Find("greedy clone").transform.position);
                    }
                }
            }

            else if (Math.Abs(Input.GetAxisRaw("Vertical")) == 1f) {
                for(int i = 0; i < 2; i++) {
                    if(!Physics2D.OverlapCircle(greedyMovePoint.position + (new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f)), 0.2f, whatStopsMovement)) {
                        greedyMovePoint.position += (new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f));
                        moves.Push(GameObject.Find("greedy clone").transform.position);
                    }
                }
            }
        }
    }
}
