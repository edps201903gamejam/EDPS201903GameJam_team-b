using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceScript : MonoBehaviour {
    
    Button Face;
    Button FaceLine;
    Button Eye;
    Button Nose;
    Button Brows;
    Button Mouse;

    public bool isTrigger = false;

	// Use this for initialization
	void Start () {
        Face = GameObject.Find("Canvas/Face").GetComponent<Button>();
        FaceLine = GameObject.Find("Canvas/FaceLine").GetComponent<Button>();
        Eye = GameObject.Find("Canvas/Eye").GetComponent<Button>();
        Nose = GameObject.Find("Canvas/Nose").GetComponent<Button>();
        Brows = GameObject.Find("Canvas/Brows").GetComponent<Button>();
        Mouse = GameObject.Find("Canvas/Mouse").GetComponent<Button>();
	}

    void Update()
    {
        if (isTrigger)
        {
            FaceLine.transform.position = new Vector3(1080, 580, 0);
            Eye.transform.position = new Vector3(1080, 490, 0);
            Nose.transform.position = new Vector3(1080, 397, 0);
            Brows.transform.position = new Vector3(1080, 304, 0);
            Mouse.transform.position = new Vector3(1080, 210, 0);
        }
    }

    public void OnClick(){
        Debug.Log("clicked");
        isTrigger = true;
    }
}
