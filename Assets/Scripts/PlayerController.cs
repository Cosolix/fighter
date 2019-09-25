using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float width = 1;
    public float height = 0.98f;

    public float groundThreshold = 0.1f;
    public Toggle groundedDisplay;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void jump(float force) {
        //rb.AddForce(new Vector2(0, force));
        rb.velocity = new Vector2(rb.velocity.x, force);
    }

    public void move(Vector2 displacement) 
    {
        Vector2 target = new Vector2(transform.position.x + displacement.x, transform.position.y);
        transform.Translate(displacement);
    }

    public bool isGrounded()
    {
        bool grounded = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - height / 2), new Vector2(0, -1), groundThreshold);
        groundedDisplay.isOn = grounded;
        return grounded;
    }
}
