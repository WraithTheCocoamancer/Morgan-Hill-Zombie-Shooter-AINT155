using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController2D : MonoBehaviour {

    public float speed = 5.0f;
    Rigidbody2D Body2D;
    void Start()
    {
        
        Body2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Body2D.velocity = new Vector2(x, y) * speed;
        Body2D.angularVelocity = 0.0f;
    }
}
