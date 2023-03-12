using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class playerMove : MonoBehaviour
{
    float speedMove = 10;
    float xDirection;
    float space;
    [SerializeField] int jumpPower;
    Rigidbody2D rb;
    public Animator animator;
    int numberJump = 0;
    //dash
    bool canDash = true;
    bool isDashing;
    float dashingPower = 17f;
    float dashingTime = 0.2f;
    float dashingCooldown = 1f;

    [SerializeField] TrailRenderer tr;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDashing)
        {
            return;
        }
        move();
        jump(); 
        if (Input.GetKeyDown(KeyCode.DownArrow) && canDash)
        {
            StartCoroutine(DashCharacter());
        }
    }
    public void move()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(xDirection));
        float moveStep = speedMove * xDirection * Time.deltaTime;
        transform.position = transform.position + new Vector3(moveStep, 0, 0);
        
    }
    public void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (numberJump==1)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    animator.SetBool("isJumping", false);
                    animator.SetBool("isJumpingDouble", true);
                    rb = GetComponent<Rigidbody2D>();
                    rb.velocity = Vector2.up * jumpPower;
                    numberJump++;
                }
            }
            if (numberJump==0)
            {
                numberJump = 0;
                animator.SetBool("isJumping", true);
                rb = GetComponent<Rigidbody2D>();
                rb.velocity = Vector2.up * jumpPower;
                numberJump++;
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("isJumpingDouble", false);
            numberJump = 0;
        }
    }
    private IEnumerator DashCharacter()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        canDash = false;
        isDashing= true;       
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(dashingPower*xDirection,0f);
        tr.emitting=true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing= false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash= true;
    }
    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }
    }
}
