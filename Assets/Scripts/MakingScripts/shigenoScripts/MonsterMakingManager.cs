using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMakingManager : SingletonMonoBehaviour<MonsterMakingManager>
{

	public GameObject clickedObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//マウスのクリックを管理。
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			//クリックされたオブジェクトを見る。
			GameObject newClickedObject = null;

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

			if (hit2d)
			{
				newClickedObject = hit2d.transform.gameObject;
			}
			//オブジェクト取ってこれなかったら弾く
			if(newClickedObject == null)
			{
				return;
			}


			if(newClickedObject.tag == "MonsterParts")
			{
				clickedObject = newClickedObject;	
				Debug.Log(newClickedObject);

			}
		}
	}

}
