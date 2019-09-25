using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour
{
    public float speed = 0.1f;
    public float jumpForce = 1;
    public int maxJumps = 2;

    private int jumpCount = 0;

    PlayerController pc;

    private void Start()
    {
        pc = GetComponent<PlayerController>();
    }

    private void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal") * speed;
        Vector2 targetDisplacement = new Vector2(input, 0);
        pc.move(targetDisplacement);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (pc.isGrounded()) {
                jumpCount = 0;
            }

            if (jumpCount < maxJumps)
            {
                pc.jump(jumpForce);
                jumpCount++;
            }
        }
    }
}
