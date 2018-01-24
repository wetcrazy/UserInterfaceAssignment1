using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {

    [SerializeField]
    GameObject wheel;

    bool isRotate = false;
   
	// Use this for initialization
	void Start () {
      
	}

    public void OnClick()
    {
        wheel.transform.Rotate(Vector3.forward, 180.0f);

        if (!isRotate)
            isRotate = true;
        else
            isRotate = false;
    }

    public bool GetisRotation()
    {
        return isRotate;
    }

    // Update is called once per frame
    void Update () {
		
	}

   
}
