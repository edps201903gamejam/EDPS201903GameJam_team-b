using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeComand : MonoBehaviour {
	int i = 0;

	//切り替え判定
	public bool Change;

	public GameObject RotateR;
	public GameObject RotateL;
	public GameObject Delete;

	public Button Up;
	public Button Down;

	// Use this for initialization
	void Start () {
		Change = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Change){
			RotateR.transform.position = new Vector3 (RotateR.transform.position.x,  -125, 0);
			RotateL.transform.position = new Vector3(RotateL.transform.position.x, -125, 0);
			Delete.transform.position = new Vector3(Delete.transform.position.x,  -125, 0);

			Up.transform.position = new Vector3(Up.transform.position.x,55,1);
			Down.transform.position = new Vector3(Down.transform.position.x, 55, 1);
		}else if(!Change){
			RotateR.transform.position = new Vector3(RotateR.transform.position.x, -75, 1);
			RotateL.transform.position = new Vector3(RotateL.transform.position.x, -75, 1);
			Delete.transform.position = new Vector3(Delete.transform.position.x, -75, 1);

			Up.transform.position = new Vector3(Up.transform.position.x, -55, 0);
			Down.transform.position = new Vector3(Down.transform.position.x, -55, 0);
		}
	}

	public void OnClick(){
		i++;
		if(i % 2 == 1){
			Change = true;
		}else if(i % 2 == 0){
			Change = false;
		}
	}
}
