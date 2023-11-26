using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heater : MonoBehaviour
{
    public Text ScriptTxt;

    int gold = 23;
    // Start is called before the first frame update
    void Start()
    {
        ScriptTxt.text = "23";
    }

    // Update is called once per frame
    public void numplus()
    {
        gold += 1;
        ScriptTxt.text = gold.ToString();
    }
    public void nummin()
    {

        gold -= 1;
        if (gold < 18)
            gold = 18;
        ScriptTxt.text = gold.ToString();
    }
}
