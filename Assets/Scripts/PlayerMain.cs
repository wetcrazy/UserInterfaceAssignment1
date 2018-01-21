using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 10;

    [SerializeField]
    float rotateSpeed = 60;

    [SerializeField]
    GameObject UIObj;

    [SerializeField]
    GameObject UIObjShoot;

    JoyScript targetScript;
    JoyScriptShoot targetScriptShoot;

    //Vector3 yAxis;

    void Awake()
    {
        Debug.Log("Awake");
    }
	// Use this for initialization
	void Start()
    {
        Debug.Log("Start");
        //yAxis = new Vector3(0, 1, 0);
        targetScript = UIObj.GetComponent<JoyScript>();
        targetScriptShoot = UIObjShoot.GetComponent<JoyScriptShoot>();
    }

    void Init()
    {

    }
	
	// Update is called once per frame
	void Update()
    {
        if (Input.GetKey(KeyCode.W) || targetScript.direction.y > 0)
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || targetScript.direction.x < 0)
        {
            transform.position -= transform.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || targetScript.direction.y < 0)
        {
            transform.position -= transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || targetScript.direction.x > 0)
        {
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }

        // Rotation
        Vector3 targetDir = targetScriptShoot.direction;
        //Debug.Log(targetDir);

        Vector3 newDir = Vector3.RotateTowards(transform.forward,
                            new Vector3(targetDir.x, 0.0f, targetDir.y),
                             Time.deltaTime * rotateSpeed, 0.0F);


        transform.rotation = Quaternion.LookRotation(newDir);


    }

    void FixedUpdate()
    {
    }
}