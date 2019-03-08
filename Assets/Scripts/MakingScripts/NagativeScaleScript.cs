using UnityEngine;
using UnityEngine.Rendering;

public class NagativeScaleScript : MonoBehaviour
{


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
			changeTargetGameObject.GetComponent<Transform>().localScale -= new Vector3(0.1f, 0.1f, 0.1f);
			Debug.Log(changeTargetGameObject + " " + changeTargetGameObject.GetComponent<SortingGroup>().sortingOrder);
			Debug.Log("You Selected Parts");
		}
	}

	public void OnClick()
	{
		changeLayer();
	}
}
