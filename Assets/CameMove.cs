using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameMove : MonoBehaviour
{
    public float Speed;
    private Vector2 MoveVelocity;

    private Rigidbody2D RB;
     void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 Move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        MoveVelocity = Move.normalized * Speed;

        RB.MovePosition(RB.position + MoveVelocity * Time.deltaTime);
    }
}
  
