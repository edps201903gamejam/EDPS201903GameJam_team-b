using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parts : MonoBehaviour {

	public MonsterParts partsType;
	private Transform parentTransform;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//partsTypeaをここで設定する。
	//座標から拾ってくるイメージ。
	public void setPartsType()
	{
		if(transform.parent == null)
		{
			Debug.LogError("深刻なエラーが発生しました。Monsterの実態となるオブジェクトが存在していないみたいです。");
			return;
		}
		else
		{
			parentTransform = transform.parent;
		}
	}

	public void testGetParts()
	{
		Debug.Log(partsType);
	}
}
