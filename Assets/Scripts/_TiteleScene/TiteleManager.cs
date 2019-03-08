using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiteleManager : MonoBehaviour {

	AudioSource audio;
	// Use this for initialization
	void Start () 
	{
		audio = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			LoadSceneManager.Instance.LoadStart("FukuwaraiScene");
			audio.Play();
		}
	}
}
