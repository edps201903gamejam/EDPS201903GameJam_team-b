using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpriteScript : MonoBehaviour {



    public bool SpriteEyeTrigger = false;

	public GameObject Parts1;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        if(SpriteEyeTrigger){
				Parts1.transform.localScale = new Vector3(20, 20);
				Instantiate(Parts1, new Vector3(200f, 100f, 1f), Quaternion.identity);
        }
		SpriteEyeTrigger = false;
	}
    public void OnClick(){
        SpriteEyeTrigger = true;
    }

}
