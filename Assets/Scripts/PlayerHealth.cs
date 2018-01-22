using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    [SerializeField]
    GameObject player;

    [SerializeField]
    float healthPoints = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddHealth(float amt)
    {
        healthPoints += amt;
        //more than maxhealth, equals max health

        if (healthPoints <= 0)
            SceneManager.LoadScene("GameOver");
    }
}
