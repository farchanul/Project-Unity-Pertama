using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public float multiplier;
    public Collider bola;
	
	private void OnCollisionEnter(Collision collision)
	{
		
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            Debug.Log("p");
            bolaRig.velocity *= multiplier;
        }
    }
}
