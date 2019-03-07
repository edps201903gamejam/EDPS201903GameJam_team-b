using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parts3Script : MonoBehaviour {
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
			FaceLine.transform.position = new Vector3(-100, FaceLine.transform.position.y, 0);
			Eye.transform.position = new Vector3(-100, Eye.transform.position.y, 0);
			Nose.transform.position = new Vector3(-100, Nose.transform.position.y, 0);
			Brows.transform.position = new Vector3(-100, Brows.transform.position.y, 0);
			Mouse.transform.position = new Vector3(-100, Mouse.transform.position.y, 0);
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
