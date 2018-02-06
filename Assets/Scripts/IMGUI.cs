using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class IMGUI : MonoBehaviour {
    public GUISkin skin;

    string textField;
    string textArea;
    bool toogle;
    float horizontalX;
    int toolbarSelection;
    
	// Use this for initialization
	void Start () {
        textField = "";
        textArea = "";
        toogle = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        if (Time.time % 2 < 1)
            GUI.Label(new Rect(100, 100, 100, 50), "DIE", skin.GetStyle("HelloText"));
        
            GUI.Box(new Rect(100, 200, 100, 50), "LA!", skin.GetStyle("HelloBox"));

        if (GUI.Button(new Rect(100, 300, 100, 50), "MEOW"))
        {
            Debug.Log("Mother Fisher!");
        }

        textField = GUI.TextField(new Rect(100, 400, 100, 50), textField);
        textArea = GUI.TextArea(new Rect(100, 500, 100, 50), textArea);

        toogle = GUI.Toggle(new Rect(200, 100, 100, 50), toogle, "Turn me on!");
        if (toogle)
            Debug.Log("Gay");
    }
}
