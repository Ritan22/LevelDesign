using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody body;
    private Vector3 velocity;
    [SerializeField] private int speed;
    

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimento del player
        velocity.x = Input.GetAxisRaw("Horizontal");
        velocity.z = Input.GetAxisRaw("Vertical");

        body.AddForce(velocity * speed);

        
    }
}
