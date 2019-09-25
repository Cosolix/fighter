using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour
{
    public float speed = 1;
    public float jumpForce = 200;
    public int jumps = 2;

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
            pc.jump(jumpForce);
        }
    }
}
