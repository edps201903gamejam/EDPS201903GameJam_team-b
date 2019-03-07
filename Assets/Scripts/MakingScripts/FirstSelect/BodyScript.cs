using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyScript : MonoBehaviour {

	Button Set1;
	Button Set2;
	Button Set3;
	public Button Parts1;
	public Button Parts2;
	public Button Parts3;


	public bool EyeTrigger = false;

	int i = 0;

	// Use this for initialization
	void Start()
	{
		Set1 = GameObject.Find("Canvas/PartsSelect/Set1").GetComponent<Button>();
		Set2 = GameObject.Find("Canvas/PartsSelect/Set2").GetComponent<Button>();
		Set3 = GameObject.Find("Canvas/PartsSelect/Set3").GetComponent<Button>();
	}

	void Update()
	{
		if (EyeTrigger)
		{
			Parts1.transform.position = new Vector3(Set1.transform.position.x, Set1.transform.position.y, 0);
			Parts2.transform.position = new Vector3(Set2.transform.position.x, Set2.transform.position.y, 0);
			Parts3.transform.position = new Vector3(Set3.transform.position.x, Set3.transform.position.y, 0);
		}
		else if (!EyeTrigger)
		{
			Parts1.transform.position = new Vector3(-100, Parts1.transform.position.y, 0);
			Parts2.transform.position = new Vector3(-100, Parts2.transform.position.y, 0);
			Parts3.transform.position = new Vector3(-100, Parts3.transform.position.y, 0);
		}
	}

	public void OnClick()
	{
		i++;
		if (i % 2 == 1)
		{
			Debug.Log("clicked");
			EyeTrigger = true;
		}else if(i % 2 == 0){
			EyeTrigger = false;
		}
	}
}
