using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class playerMove : MonoBehaviour
{
    /*public float speedMove = 5;
    float xDirection;
    float yDirection;
    Rigidbody2D rb;
    public Animator animator;
    private Rigidbody2D rb2D;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        move();
        
    }
    public void move()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(xDirection));
        float moveStepx = speedMove * xDirection * Time.deltaTime;
        transform.position = transform.position + new Vector3(moveStepx, 0, 0);
        yDirection = Input.GetAxisRaw("Vertical");
        animator.SetFloat("speed", Mathf.Abs(yDirection));
        float moveStepy = speedMove * yDirection * Time.deltaTime;
        transform.position = transform.position + new Vector3(0, moveStepy, 0);



    }*/
    public FixedJoystick joystick;
    public float moveSpeed = 1f;
    public ContactFilter2D moveFilter;
    public float collisionOffset = 0.05f;
    Vector2 moveInput;

    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;

    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    public bool immune = false;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
       

        moveInput.x = joystick.Horizontal;
        moveInput.y = joystick.Vertical;
        if (moveInput != Vector2.zero)
        {
            bool success = TryMove(moveInput);
            if (!success && moveInput.x > 0)
            {
                success = TryMove(new Vector2(moveInput.x, 0));

            }
            if (!success && moveInput.y > 0)
            {
                success = TryMove(new Vector2(0, moveInput.y));
            }

            animator.SetFloat("speed", 1);
        }
        else
        {
            animator.SetFloat("speed", 0);
        }

        //set direction of sprites
       
    }
    private bool TryMove(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            int count = rb.Cast(
            direction,
            moveFilter,
            castCollisions,
            moveSpeed * Time.fixedDeltaTime + collisionOffset
            );
            if (count == 0)
            {
                rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
                return true;
            }
            else
            {
                return false;

            }
        }
        else
        {
            return false;
        }

    }

   
}
