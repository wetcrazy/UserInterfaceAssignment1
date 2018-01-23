using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    [SerializeField]
    GameObject player;

    [SerializeField]
    float healthPoints = 100.0f;

    [SerializeField]
    float maxHp = 100.0f;

    [SerializeField]
    Slider Hpbar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Regen();
        //Debug.Log(healthPoints);
        Hpbar.value = healthPoints / maxHp;
    }

    public void AddHealth(float amt)
    {
        healthPoints += amt;
        //more than maxhealth, equals max health

        if (healthPoints <= 0)
            SceneManager.LoadScene("GameOver");
    }

    void Regen()
    {
        if (healthPoints < maxHp)
            healthPoints += 1.0f * Time.deltaTime;
    }
}
