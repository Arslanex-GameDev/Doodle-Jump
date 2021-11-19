using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private float jumpForse = 10f;

private void OnCollisionEnter2D(Collision2D other) {
    Rigidbody2D rb = other.collider.GetComponent<Rigidbody2D>();
    if(rb != null){
            Vector3 velocity = rb.velocity;
    velocity.y = jumpForse;
    rb.velocity = velocity;
    }
  }
}
