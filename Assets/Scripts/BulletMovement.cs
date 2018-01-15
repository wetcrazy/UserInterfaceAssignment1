using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    [SerializeField]
    float movementSpeed = 10;
    [SerializeField]
    float lifeSpan = 5;

    float lifeTime = 0;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += transform.up * movementSpeed * Time.deltaTime;
        Destroy(gameObject, lifeSpan);
    }

    void OnTriggerEnter(Collider other)
    {
      //  Debug.Log(other.gameObject.name);
    }
    void OnCollisionEnter(Collision collision)
    {
       // Debug.Log(collision.gameObject.name);
    }
}
