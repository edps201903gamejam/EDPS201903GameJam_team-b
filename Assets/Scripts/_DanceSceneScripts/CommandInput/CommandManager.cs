using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using Monster;

namespace DanceScene
{
	public class CommandManager : SingletonMonoBehaviour<CommandManager>
	{
		public KeyCode[] danceButton;
		private KeyCode[] danceCommand;

		public int commandNum;

		[SerializeField] private Text[] commandTexts;

		//入力受付中のコマンドを格納するとこ
		private KeyCode nextCommand;
		private int commandState = 0;

		//正解不正解のGameObjectを格納するとこ
		[SerializeField] private GameObject CorrectObj;
		[SerializeField] private GameObject IncorrectObj;

		//UI
		[SerializeField] private Animator animator;

		private GameObject[] monsterParts;

		private int playCount = 0;
		private bool isCommandSceneEnd = false;

		private void Start()
		{
			//モンスターのパーツを取得する。
			monsterParts = GameObject.FindGameObjectsWithTag("MonsterParts");
			Debug.Log(monsterParts.Length);
		}


		// Update is called once per frame
		void Update () 
		{
			//test
			if (Input.GetKeyDown(KeyCode.T))
			{
				commandGenerate();
				commandTextApply();
			}

			if(isCommandSceneEnd)
			{
				return;
			}

			//待機状態もしくは暗記状態の場合は何もしない。
			if(DanceSceneManager.Instance.nowState == DanceSceneManager.INPUT_STATE.WAIT || 
			   DanceSceneManager.Instance.nowState == DanceSceneManager.INPUT_STATE.COMMAND_REMENBER)
			{
				return;
			}


			Debug.Log("ANSWER:" + danceCommand[commandState]);

			//コマンドが正しく入力されているかを確認する。
			//マウスの入力を弾く。
			if(Input.anyKeyDown && !Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2))
			{
				if (Input.GetKeyDown(danceCommand[commandState]))
				{
					Debug.Log("正解です");
					//CommandのStateを増やす
					commandState += 1;
					commandState = Mathf.Clamp(commandState, 0, commandNum);

					//全てのパーツオブジェクトに対してポージング作用をさせる。
					//重いからコルーチンに投げたほうが良い???

					for (int i = 0; i < monsterParts.Length;i++)
					{
						monsterParts[i].GetComponent<Parts>().correctPosing();
					}


				}
				else
				{
					Debug.Log("不正解です。INPUT_STATEをWAITに戻します。");
					DanceSceneManager.Instance.nowState = DanceSceneManager.INPUT_STATE.WAIT;
					IncorrectObj.SetActive(true);

					commandState = 0;

					playCount += 1;
					if (playCount == DanceSceneManager.Instance.playMaxTime)
					{
						isCommandSceneEnd = true;
						Debug.Log("End LIVE!");
						return;
					}
					Invoke("resetResultObject", 2);
					//animator.Play("CountDownAnimation");

				}

			}


			if (commandState == commandNum)
			{
				Debug.Log("大正解！");
				DanceSceneManager.Instance.nowState = DanceSceneManager.INPUT_STATE.WAIT;
				CorrectObj.SetActive(true);

				commandState = 0;
				DanceSceneManager.Instance.correctCount += 1;
				playCount += 1;
				if (playCount == DanceSceneManager.Instance.playMaxTime)
				{
					isCommandSceneEnd = true;
					Debug.Log("End LIVE!");
					return;
				}

				Invoke("resetResultObject", 2);

			}

		}



		//新しいコマンドを生成する。
		public void commandGenerate()
		{
			Array.Resize(ref danceCommand,commandNum);
			for (int i = 0; i < commandNum; i++)
			{
				var keyNum = Random.Range(0, danceButton.Length);
				//Debug.Log(danceButton[keyNum]);
				danceCommand[i] = danceButton[keyNum];
				//Debug.Log(danceCommand[i]);
			}
		}




		//新しいコマンドを取得して表示する。
		public void commandTextApply()
		{
			for (int i = 0; i < commandNum;i++)
			{
				commandTexts[i].gameObject.SetActive(true);
				commandTexts[i].text = danceCommand[i].ToString();
			}
		}


		//コマンドのtextを非表示にする。
		public void commandTextSetInactive()
		{
			for (int i = 0; i < commandTexts.Length;i++)
			{
				commandTexts[i].gameObject.SetActive(false);
			}
		}

		//正解不正解のオブジェクトを再度非表示にする
		private void resetResultObject()
		{
			CorrectObj.SetActive(false);
			IncorrectObj.SetActive(false);
			animator.Play("CountDownAnimation", 0, 0);
		}


	}	

}
