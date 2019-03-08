using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using charamaking;

public class TopButton : MonoBehaviour {


	public void OnClick()
	{
		CharaMakingManager.Instance.isSelectFace = !CharaMakingManager.Instance.isSelectFace;

		for (int i = 0; i < CharaMakingManager.Instance.partsButtons.Length; i++)
		{
			CharaMakingManager.Instance.partsButtons[i].spliteChange();
		}

	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
