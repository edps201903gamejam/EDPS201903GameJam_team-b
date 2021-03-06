﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parts3Script : MonoBehaviour {

	float i;
	float j;
	float k;
	float l;
	float m;

	Button Face;
	Button Body;
	Button Hand;
	Button Legs;
	Button Other;

	Button FaceLine;
	Button Eye;
	Button Nose;
	Button Brows;
	Button Mouse;
	Button Set3;
	public Button Parts3;

	public bool EyeTrigger = false;

	// Use this for initialization
	void Start()
	{
		Face = GameObject.Find("Canvas/FirstSelect/Face").GetComponent<Button>();
		Body = GameObject.Find("Canvas/FirstSelect/Body").GetComponent<Button>();
		Hand = GameObject.Find("Canvas/FirstSelect/Hand").GetComponent<Button>();
		Legs = GameObject.Find("Canvas/FirstSelect/Legs").GetComponent<Button>();
		Other = GameObject.Find("Canvas/FirstSelect/Other").GetComponent<Button>();

		FaceLine = GameObject.Find("Canvas/FirstSelect/FaceLine").GetComponent<Button>();
		Eye = GameObject.Find("Canvas/FirstSelect/Eye").GetComponent<Button>();
		Nose = GameObject.Find("Canvas/FirstSelect/Nose").GetComponent<Button>();
		Brows = GameObject.Find("Canvas/FirstSelect/Brows").GetComponent<Button>();
		Mouse = GameObject.Find("Canvas/FirstSelect/Mouse").GetComponent<Button>();
		Set3 = GameObject.Find("Canvas/PartsSelect/Set3").GetComponent<Button>();
	}

	void Update()
	{
		if (EyeTrigger)
		{
			Parts3.transform.position = new Vector3(Set3.transform.position.x, Set3.transform.position.y, 0);
		}
		EyeTrigger = false;
	}

	public void OnClick()
	{
		Debug.Log("clicked");
		EyeTrigger = true;
	}
}
