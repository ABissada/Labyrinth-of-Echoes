using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class vertical_clone_movement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Transform verticalMovePoint;

    public LayerMask whatStopsMovement;

    public SpriteRenderer sr;

    Stack<Vector3> moves = new Stack<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        verticalMovePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, verticalMovePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, verticalMovePoint.position) == 0f) {

            if (Input.GetKey(KeyCode.U) && moves.Count != 0) {
                verticalMovePoint.position = moves.Pop();
            }

            if (Input.GetAxisRaw("Horizontal") == -1f) {
                sr.flipX = true;
                if(!Physics2D.OverlapCircle(verticalMovePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), 0.2f, whatStopsMovement)) {
                    verticalMovePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                    moves.Push(GameObject.Find("vertical clone").transform.position);
                }
            }

            else if (Input.GetAxisRaw("Horizontal") == 1f) {
                sr.flipX = false;
                if(!Physics2D.OverlapCircle(verticalMovePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), 0.2f, whatStopsMovement)) {
                    verticalMovePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                    moves.Push(GameObject.Find("vertical clone").transform.position);
                }
            }

            else if (Math.Abs(Input.GetAxisRaw("Vertical")) == 1f) {
                if(!Physics2D.OverlapCircle(verticalMovePoint.position - new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), 0.2f, whatStopsMovement)) {
                    verticalMovePoint.position -= new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                    moves.Push(GameObject.Find("vertical clone").transform.position);
                }
            }
        }
    }
}

