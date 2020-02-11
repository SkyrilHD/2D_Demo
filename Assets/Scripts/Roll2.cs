using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll2 : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        if (Input.GetKeyDown("space")){
            transform.Translate(Vector3.up * 25 * Time.deltaTime, Space.World);
        
        }
        
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
        
        rb.AddForce(movement * speed);
    }

}
