using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeScript : MonoBehaviour
{

    Button Eye;
    Button EyeParts1;

    public bool EyeTrigger = false;

    // Use this for initialization
    void Start()
    {
        Eye = GameObject.Find("Canvas/Eye").GetComponent<Button>();
        EyeParts1 = GameObject.Find("Canvas/FirstSelect/EyeParts1").GetComponent<Button>();
    }

    void Update()
    {
        if (EyeTrigger)
        {
            EyeParts1.transform.position = new Vector3(75, 600, 0);
        }
    }

    public void OnClick()
    {
        Debug.Log("clicked");
        EyeTrigger = true;
    }
}
