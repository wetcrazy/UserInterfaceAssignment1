﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationMenu : MonoBehaviour {

    public GameObject Panel1;

    public void HidePanel()
    {
        Panel1.gameObject.SetActive(false);
    }

    public void ShowPanel()
    {
        Panel1.gameObject.SetActive(true);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
