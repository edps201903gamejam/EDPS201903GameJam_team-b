using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpriteScript : MonoBehaviour {



    public bool SpriteEyeTrigger = false;

    public GameObject EyeParts1;

	// Use this for initialization
	void Start () {
        EyeParts1 = GameObject.Find("EyeParts1").GetComponent<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {
        if(SpriteEyeTrigger){
            Instantiate(EyeParts1, new Vector3(200, 100, 1), Quaternion.identity);
        }
	}
    public void OnClick(){
        SpriteEyeTrigger = true;
    }

}
