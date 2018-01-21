using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour {

    [SerializeField]
    GameObject bullet;

    [SerializeField]
    float cooldown = 1.0f;

    float elapsedtime = 0.0f;

    bool isdown = false;

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
        // When mouse button is pressed
        /*
        if (Input.GetMouseButtonDown(0))
        {
            //create a bullet
            Instantiate(bullet, transform.position, transform.rotation);
        }*/

       
        // Only shoots
        if (isdown)
        {
            elapsedtime += cooldown * Time.deltaTime;
            Debug.Log(elapsedtime);
            if (elapsedtime <= 0)
            {               
                Instantiate(bullet, transform.position, transform.rotation);
            }
            else if (elapsedtime >= cooldown)
            {
                elapsedtime = 0.0f;           
            }             
        }        
    }
}
