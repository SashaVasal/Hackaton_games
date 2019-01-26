using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Joystick joystick;
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 moveInputX = new Vector2(joystick.Horizontal,0);
        Vector2 moveInputY = new Vector2(0, joystick.Vertical);
        moveVelocity = (moveInputX + moveInputY) * speed;
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        float Zangle = Mathf.Atan2(joystick.Horizontal, joystick.Vertical) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y,-Zangle);
    }
}
