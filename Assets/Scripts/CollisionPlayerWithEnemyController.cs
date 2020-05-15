using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerWithEnemyController : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
