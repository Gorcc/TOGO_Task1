using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Transform pos;
    public Rigidbody rb;
    [SerializeField] private FixedJoystick joystick;
    public float forwardForce = 100f;
    public float horizontalForce = 10f;
    public float maxSpeed = 25f;
    
    void Start()
    {

        
    }
    void FixedUpdate()
    {
        var pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, -7.0f, 7.0f);
        transform.position = pos;
        rb.AddForce(joystick.Horizontal * horizontalForce *Time.deltaTime, 0, forwardForce * Time.deltaTime);

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

    }
}
