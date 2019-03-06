using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanceScene
{
	public class DanceSceneManager : SingletonMonoBehaviour<DanceSceneManager>
	{
		public float rememberTime = 1.0f;
		public int correctCount = 0;
		public int playMaxTime = 10;
		public enum INPUT_STATE
		{
			WAIT,
			COMMAND_REMENBER,
			COMMAND_INPUT,
		};

		public INPUT_STATE nowState;

		public void startRememberWait()
		{
			StartCoroutine(rememberWait());
		}

		public IEnumerator rememberWait()
		{
			//暗記時間が終わったら入力ステートへ以降。
			yield return new WaitForSeconds(rememberTime);
			nowState = INPUT_STATE.COMMAND_INPUT;
			CommandManager.Instance.commandTextSetInactive();
		}



	}
}

