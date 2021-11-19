using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb ;
    private float movement = 0f;
    private float movementSpeed = 5f;
    private float levelWidth = 3f;
    private Vector3 playerPos;
    private CameraFollow cameraFollow;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cameraFollow = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>();
    }

    void Update()
    {
        if(cameraFollow.gameOver == true){
            Destroy(gameObject);
        }
        playerPos = transform.position;
        movement = Input.GetAxis("Horizontal")*movementSpeed;
        Vector3 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
        if(playerPos.x > levelWidth ){
            playerPos.x = -levelWidth;
        }
        else if(playerPos.x < -levelWidth){
            playerPos.x = levelWidth;
        }
        transform.position = playerPos;
    }
}
