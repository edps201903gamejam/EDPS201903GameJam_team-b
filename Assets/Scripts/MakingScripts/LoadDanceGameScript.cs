using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDanceGameScript : MonoBehaviour {

	[SerializeField] private GameObject playerMonster;

    public void OnClick()
	{

		generateMonster();
        SceneManager.LoadScene("DanceScene");
    }

	private void generateMonster()
	{
		if(playerMonster == null)
		{
			Debug.LogError("深刻なエラーが発生しています。シーンにPlayeraaがいないとかLoadDanceGameScriptにPlayerがアタッチされてないです。");
			return;
		}

		GameObject[] _partsParent = GameObject.FindGameObjectsWithTag("MonsterPartsParent");

		//補正する
		for (int i = 0; i < _partsParent.Length;i++)
		{
			_partsParent[i].transform.localPosition = new Vector2(0, 0);
			_partsParent[i].transform.localScale = new Vector3(1, 1, 0);

			_partsParent[i].transform.parent = playerMonster.transform;
		}

		DontDestroyOnLoad(playerMonster.gameObject);
	}
}
