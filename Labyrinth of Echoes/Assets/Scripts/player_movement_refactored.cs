using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Mail;
using System.Threading;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class player_movement_refactored : MonoBehaviour
{

    public virtual float moveSpeed { get; set; } = 3f;


    public Transform playerMovePoint;

    public LayerMask whatStopsMovement;

    public SpriteRenderer sr;

    public int moveCount = 0;

    public AudioSource audioSource;
    public AudioClip[] audioClipArray;
    public float volume=0.5f;

    public Stopwatch stopWatch = new Stopwatch();


    Stack<Vector3> moves = new Stack<Vector3>();



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

            if (Input.GetKey(KeyCode.U) && moves.Count != 0) {
                undo();
            }

            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            if (horizontal != 0 || vertical != 0){
                if (horizontal != 0 && vertical != 0) {
                    vertical = 0f;
                }
                callMove(horizontal, vertical);
            }


            }
    }

    public virtual void callMove(float horizontal, float vertical){
        move(horizontal, vertical);
    }

    public void move(float Horizontal, float Vertical){
        moveCount += 1;
        if(!Physics2D.OverlapCircle(playerMovePoint.position + new Vector3(Horizontal, Vertical, 0f), 0f, whatStopsMovement)) {
            playerMovePoint.position += new Vector3(Horizontal, Vertical, 0f);
            moves.Push(GameObject.Find(gameObject.name).transform.position);
            if(audioSource) {
                audioSource.PlayOneShot(audioClipArray[UnityEngine.Random.Range(0, audioClipArray.Length)], volume);
            }
        }
        if (Horizontal == 1f) {
            sr.flipX = false;
        }
        if (Horizontal == -1f) {
            sr.flipX = true;
        }
    }

    public void undo(){
        playerMovePoint.position = moves.Pop();
        moveCount -= 1;
    }

}
