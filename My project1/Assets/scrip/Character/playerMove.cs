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
    float yDirection;
    [SerializeField] int jumpPower;
    Rigidbody2D rb;
    public Animator animator;
    [SerializeField] TrailRenderer tr;
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
        Debug.Log(Mathf.Abs(xDirection));
        Debug.Log(Mathf.Abs(yDirection));
        float moveStepy = speedMove * yDirection * Time.deltaTime;
        transform.position = transform.position + new Vector3(0, moveStepy, 0);



    }
}
