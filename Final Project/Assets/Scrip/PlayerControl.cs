using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    [SerializeField] float speed = 5;
    private Vector3 Move;
    bool Dash;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            moveX += -1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX += 1f;
        }

        Move = new Vector3(moveX, 0).normalized;

        Animate();

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Dash = true;
        }*/

    }

    private void FixedUpdate()
    {

        rigidbody.velocity = Move * speed;
        if (Dash)
        {
            float DashAmount = 3f;
            rigidbody.MovePosition(transform.position + Move * DashAmount);
            Dash = false;
        }
    }

    void Animate()
    {
        if (Input.GetKey("a"))
        {
            animator.SetBool("RunToL", true);
        }
        if (!Input.GetKey("a"))
        {
            animator.SetBool("RunToL", false);
        }

        if (Input.GetKey("d"))
        {
            animator.SetBool("RunToR", true);
        }
        if (!Input.GetKey("d"))
        {
            animator.SetBool("RunToR", false);
        }
    }
}
