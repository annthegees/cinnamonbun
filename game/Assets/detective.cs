using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;


public class detective : MonoBehaviour
{
    public float moveSpeed = 5f;
    new Rigidbody2D rigidbody2D;
    public Animator animator;
    Vector2 movement; 
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        //float horizontal = Input.GetAxisRaw("Horizontal");
        //float vertical = Input.GetAxisRaw("Vertical");
        //Vector2 position = rigidbody2D.position;
        //position.x = position.x + 3f * horizontal * Time.deltaTime;
        //position.y = position.y + 3f * vertical * Time.deltaTime;
        // rigidbody2D.MovePosition(position);
        //animator.SetFloat("Horisontal", horizontal);
        // animator.SetFloat("Speed", position.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        rigidbody2D.MovePosition(rigidbody2D.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
