using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectLogic : MonoBehaviour {

    [SerializeField]
    int level = 1;

    [SerializeField]
    int Maxlevel = 3;

    [SerializeField]
    public Text printout;

    public void ClickedNextLevel()
    {
        ++level;
        if (level > 3)
        {
            level = 1;
        }

        printout.text = "Level " + level;
        
    }

    public void ClickedPrevLevel()
    {
        --level;

        if (level < 1)
            level = Maxlevel;

        printout.text = "Level " + level;
    }

    public string GetLevelString()
    {
        return printout.text;
    }
    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}
}
