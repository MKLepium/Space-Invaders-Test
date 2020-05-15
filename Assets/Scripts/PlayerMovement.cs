using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 10;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical);
        GetComponent<Rigidbody2D>().velocity = direction.normalized * speed;

        GetComponent<Animator>().SetBool("isFlyingUp", (vertical > 0));
        GetComponent<Animator>().SetBool("isFlyingLeft", (horizontal < 0));
        GetComponent<Animator>().SetBool("isFlyingRight", (horizontal > 0));

    }
}
