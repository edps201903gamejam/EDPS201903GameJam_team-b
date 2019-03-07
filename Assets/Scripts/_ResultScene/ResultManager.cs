using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanceScene;
using UnityEngine.UI;

public class ResultManager : SingletonMonoBehaviour<ResultManager> {

	private int _correctCount = 0;
	private int scoreCounter = 0;
	[SerializeField] private Text scoreText;

	private AudioSource _audio;
	[SerializeField] private float audioWaitTime;

	private bool isCountEnd;
	// Use this for initialization
	void Start () 
	{
		_audio = GetComponent<AudioSource>();
		_correctCount = DanceSceneManager.CORRECT_COUNT;
		StartCoroutine(soundPlay());
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(isCountEnd)
		{
			Debug.Log("countEnd");
			return;	
		}

		if(_correctCount * 100 > scoreCounter)
		{
			scoreCounter += 7;
			scoreCounter = Mathf.Clamp(scoreCounter, 0, _correctCount * 10);
			scoreText.text = scoreTextApply(scoreCounter);
			return;
		}

		//StopCoroutine(soundPlay());
		isCountEnd = true;
	}

	private string scoreTextApply(int countedScore)
	{
		int handred = countedScore / 100;
		int ten = countedScore % 100 / 10;
		int one = countedScore % 10;

		string handredString = handred.ToString();
		string tenString = ten.ToString();
		string oneString = one.ToString();

		if(handred == 0)
		{
			handredString = "<color=#323232>0</color>";
		}
		else
		{
			handredString = handred.ToString();
			handredString = "<color=#FF006F>" + handredString + "</color>";
		}

		if(handred == 0 && ten == 0)
		{
			tenString = "<color=#323232>0</color>";
		}
		else
		{
			tenString = ten.ToString();
			tenString = "<color=#FF006F>" + tenString + "</color>";
		}

		if (handred == 0 && ten == 0 && one == 0)
		{
			oneString = "<color=#323232>0</color>";
		}
		else
		{
			oneString = one.ToString();
			oneString = "<color=#FF006F>" + oneString + "</color>";
		}

		var result = handredString + tenString + oneString;

		return result;
	}

	private IEnumerator soundPlay()
	{
		while(!isCountEnd)
		{
			_audio.Play();
			Debug.Log("play");
			yield return new WaitForSeconds(audioWaitTime);
		}

		yield break;
	}


	//[ContextMenu("Test")]
	//private void test()
	//{
		
	//}
}
