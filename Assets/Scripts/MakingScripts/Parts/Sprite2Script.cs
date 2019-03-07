using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite2Script : MonoBehaviour {



    public bool SpriteEyeTrigger = false;

	public GameObject Parts2;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{

		if (SpriteEyeTrigger)
		{
			Parts2.transform.localScale = new Vector3(20, 20);
			Instantiate(Parts2, new Vector3(200f, 100f, 1f), Quaternion.identity);
		}
		SpriteEyeTrigger = false;
	}
	public void OnClick()
	{
		SpriteEyeTrigger = true;
	}

}
