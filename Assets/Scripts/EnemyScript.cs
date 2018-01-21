using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 5;


    public Transform target;
    public Transform mytransform;

    // Use this for initialization
    void Start ()
    {
        target = GameObject.FindWithTag("Player").transform;
        Debug.Log(target);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Bullet"))
        {
            Health healthScript = GetComponent<Health>();
            healthScript.AddHealth(-1f);
            Destroy(other.gameObject);
        }
    }
}
