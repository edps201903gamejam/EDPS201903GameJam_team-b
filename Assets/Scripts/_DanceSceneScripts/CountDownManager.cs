using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanceScene
{
	public class CountDownManager : SingletonMonoBehaviour<CountDownManager>
	{

		// Use this for initialization
		private void OnEnable()
		{
			sendCountDownStart();
		}

		private void OnDisable()
		{
			sendCountDownEnd();
		}



		public void sendCountDownStart()
		{
			DanceSceneManager.Instance.nowState = DanceSceneManager.INPUT_STATE.WAIT;
		}


		public void sendCountDownEnd()
		{
			
			DanceSceneManager.Instance.nowState = DanceSceneManager.INPUT_STATE.COMMAND_REMENBER;

			//コマンドを新しく作成。
			CommandManager.Instance.commandGenerate();
			CommandManager.Instance.commandTextApply();

			//暗記の時間を開始。
			DanceSceneManager.Instance.startRememberWait();

			//コマンド入力のタイマーを起動。
			CommandTimerManager.Instance.timerStart();

			//gameObject.SetActive(false);
		}
	}
}

