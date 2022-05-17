using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redBlock : MonoBehaviour
{
    public int strengt = 2;

    void OnCollisionEnter2D(Collision2D collisionInfo) {
	if (strengt != 1){
	    strengt--;
	} else {
	    Destroy(gameObject);
	}
    }
}
