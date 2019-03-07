using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PartsLayerNegativeChange : MonoBehaviour {


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void changeLayer()
	{
		GameObject changeTargetGameObject = MonsterMakingManager.Instance.clickedObject;

		//何も取得していなかった場合は弾く。
		if (changeTargetGameObject == null)
		{
			return;
		}
		//aMonsterPartsを受け取っていた場合の処理。
		if (changeTargetGameObject.tag == "MonsterParts")
		{
			changeTargetGameObject.GetComponent<SortingGroup>().sortingOrder -= 1;
			Debug.Log(changeTargetGameObject + " " + changeTargetGameObject.GetComponent<SortingGroup>().sortingOrder);
			Debug.Log("You Selected Parts");
		}
	}

	public void OnClick()
	{
		changeLayer();
	}
}
