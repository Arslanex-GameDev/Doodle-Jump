using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    public bool gameOver = false;

    private void LateUpdate() {
        if(target != null){
            if(transform.position.y-10 > target.position.y){
                gameOver = true;
            }
            else if(target.position.y > transform.position.y){
                Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
                transform.position = newPos;
            }
        }
    }
}
