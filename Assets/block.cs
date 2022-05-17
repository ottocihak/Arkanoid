using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{

    public GameObject blockColor;
    public int strength;

    void OnStart() {
    	switch (blockColor) {
	    case ("red"):
		strength = 4;
		break;
	    case ("yellow"):
		strength = 3;
		break;
	    case ("yellow"):
		strength = 2;
		break;
	    default:
		strength = 1;
		break;
	}
    }

    void OnCollisionEnter2D(Collision2D collisionInfo) {
	Destroy(gameObject);
    }
}
