using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    [SerializeField] float speed = 5;
    private Vector3 Move;
    bool Dash;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dash = true;
        }

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
}
