using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 100.0f;

    void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    float hitRacket (Vector2 ballPos, Vector2 racketPos, 
		float racketWidtgh) {
	return (ballPos.x - racketPos.x) / racketWidtgh;
    }

    void OnCollisionEnter2D (Collision2D coll) {
	if (coll.gameObject.name == "racket") {
	     float x=hitRacket(transform.position,
                          coll.transform.position,
                          coll.collider.bounds.size.x);
	     Vector2 dir = new Vector2(x, 1).normalized;
	     GetComponent<Rigidbody2D>().velocity = dir * speed;
	}
    }
}
