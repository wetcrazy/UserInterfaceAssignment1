using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour {

    [SerializeField]
    GameObject bullet;

    [SerializeField]
    GameObject bulletfast;

    float elapsedtime;
    bool isdown = false;

    [SerializeField]
    Rotater rotater;

    // Use this for initialization
    void Start () {
        
	}
	
    public void BtnAFire()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }


    // For Shooting on hold
    public void OnDown()
    {
        isdown = true;
    }

        public void OnUp()
    {
        isdown = false;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedtime += Time.deltaTime;
        // When mouse button is pressed
        /*
        if (Input.GetMouseButtonDown(0))
        {
            //create a bullet
            Instantiate(bullet, transform.position, transform.rotation);
        }*/

        //Debug.Log(elapsedtime);
        // Shooter on joystick down
        if (isdown)
        {
            if (elapsedtime >= 0.5f && !rotater.GetisRotation())
            {                           
                Instantiate(bullet, transform.position, transform.rotation);
                elapsedtime = 0.0f;
                //Debug.Log(elapsedtime);
            }     
            else if(elapsedtime >= 0.1f && rotater.GetisRotation())
            {
                Instantiate(bulletfast, transform.position, transform.rotation);
                elapsedtime = 0.0f;
            }  
        }        

    }
}
