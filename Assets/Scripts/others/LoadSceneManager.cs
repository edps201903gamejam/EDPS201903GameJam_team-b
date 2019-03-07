using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadSceneManager : SingletonMonoBehaviour<LoadSceneManager>
{

	//[SerializeField] private string LoadSceneName;
	[HideInInspector] public bool isLoadStarted;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void LoadStart(string loadName)
	{
		//多重ロードを防ぐ為に何らかのシーンをロード済みだった時は弾く。
		if(!isLoadStarted)
		{
			SceneManager.LoadScene(loadName);
			isLoadStarted = true;
		}
	}
}
