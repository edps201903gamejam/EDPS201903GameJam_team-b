using System.Collections;
using System.Collections.Generic;
using Monster;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDanceGameScript : MonoBehaviour {

	[SerializeField] private GameObject playerMonster;
	private GameObject monsterBody;

    public void OnClick()
    {
	    GameObject[] _parts = GameObject.FindGameObjectsWithTag("MonsterParts");
	    
	    monsterBody = GameObject.FindWithTag("Body");

	    if (monsterBody == null)
	    {
		    Debug.Log("Bodyが一個もありません。Bodyを生成してください");
		    return;
	    }

		generateMonster();
        SceneManager.LoadScene("DanceScene");
    }

	private void generateMonster()
	{
		if(playerMonster == null)
		{
			Debug.LogError("深刻なエラーが発生しています。シーンにPlayerがいないとかLoadDanceGameScriptにPlayerがアタッチされてないです。");
			return;
		}

		//Bodyの親オブジェクトにプレイヤーを指定。
		monsterBody.transform.parent = playerMonster.transform;
		
		//
		//微修正する処理。
		//
		
		GameObject[] _partsParent = GameObject.FindGameObjectsWithTag("MonsterPartsParent");
		

		
		//補正する
		for (int i = 0; i < _partsParent.Length;i++)
		{
			

			//パーツオブジェクトをbodyの実体オブジェクト以下の階層に置き換える。
			_partsParent[i].transform.parent = monsterBody.transform.GetChild(0).transform;
		}
		
		monsterBody.transform.GetChild(0).transform.position = Vector3.zero;

		DontDestroyOnLoad(playerMonster.gameObject);
	}
}
