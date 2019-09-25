using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float width = 1;
    public float height = 0.98f;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void jump(float force) {
        rb.AddForce(new Vector2(0, force));
    }

    public void move(Vector2 displacement) 
    {
        Vector2 target = new Vector2(transform.position.x + displacement.x, transform.position.y);
        transform.Translate(displacement);
    }
}
