﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackScript : MonoBehaviour
{

	Button Face;
	Button Body;
	Button Hand;
	Button Legs;
	Button Other;

	Button Back;
	Button Eye;
	Button Nose;
	Button Brows;
	Button Mouse;

	public bool isTrigger = false;

	//各ボタンの取得
	void Start()
	{
		//初期ボタン
		Face = GameObject.Find("Canvas/FirstSelect/Face").GetComponent<Button>();
		Body = GameObject.Find("Canvas/FirstSelect/Body").GetComponent<Button>();
		Hand = GameObject.Find("Canvas/FirstSelect/Hand").GetComponent<Button>();
		Legs = GameObject.Find("Canvas/FirstSelect/Legs").GetComponent<Button>();
		Other = GameObject.Find("Canvas/FirstSelect/Other").GetComponent<Button>();

		//挿入ボタン
		Back = GameObject.Find("Canvas/FirstSelect/FaceLine").GetComponent<Button>();
		Eye = GameObject.Find("Canvas/FirstSelect/Eye").GetComponent<Button>();
		Nose = GameObject.Find("Canvas/FirstSelect/Nose").GetComponent<Button>();
		Brows = GameObject.Find("Canvas/FirstSelect/Brows").GetComponent<Button>();
		Mouse = GameObject.Find("Canvas/FirstSelect/Mouse").GetComponent<Button>();

	}

	void Update()
	{
		
		if (isTrigger)
		{
			Face.transform.position = new Vector3(Back.transform.position.x, Face.transform.position.y, 1);
			Body.transform.position = new Vector3(Eye.transform.position.x, Body.transform.position.y, 1);
			Hand.transform.position = new Vector3(Nose.transform.position.x, Hand.transform.position.y, 1);
			Legs.transform.position = new Vector3(Brows.transform.position.x, Legs.transform.position.y, 1);
			Other.transform.position = new Vector3(Mouse.transform.position.x, Other.transform.position.y, 1);

			Back.transform.position = new Vector3(-200, Face.transform.position.y, 0);
			Eye.transform.position = new Vector3(-200, Body.transform.position.y, 0);
			Nose.transform.position = new Vector3(-200, Hand.transform.position.y, 0);
			Brows.transform.position = new Vector3(-200, Legs.transform.position.y, 0);
			Mouse.transform.position = new Vector3(-200, Other.transform.position.y, 0);
		}
		isTrigger = false;
	}

	public void OnClick()
	{
		Debug.Log("clicked");
		isTrigger = true;
	}
}
