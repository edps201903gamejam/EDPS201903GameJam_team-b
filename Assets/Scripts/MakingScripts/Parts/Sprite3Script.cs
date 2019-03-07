using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sprite3Script : MonoBehaviour {



    public bool SpriteEyeTrigger = false;
	public float size;
	public GameObject Parts3;
	public Button SetParts1;
	public Button SetParts2;
	public Button SetParts3;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		
		if (SpriteEyeTrigger)
		{
			Parts3.transform.localScale = new Vector3(size,size);
			Instantiate(Parts3, new Vector3(0f, 0f, 1f), Quaternion.identity);
			SetParts1.transform.position = new Vector3(-100, SetParts1.transform.position.y, 0);
			SetParts2.transform.position = new Vector3(-100, SetParts2.transform.position.y, 0);
			SetParts3.transform.position = new Vector3(-100, SetParts3.transform.position.y, 0);
		}
		SpriteEyeTrigger = false;
	}
	public void OnClick()
	{
		SpriteEyeTrigger = true;
	}

}
