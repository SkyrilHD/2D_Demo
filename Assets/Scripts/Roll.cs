using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate(){
        float moveHorizontal = 0.0f;
        float moveVertical = 0.5f;
        
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        
        rb.AddForce(movement * speed);
    }
}
