using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

namespace DanceScene
{
	public class CommandGenerator
	{
		private KeyCode[] danceKeyCodes;
		public KeyCode[] GenerateCommand()
		{
			for (int i = 0; i < CommandManager.Instance.commandNum; i++)
			{
				//CommandManagerに格納されているdanceButtonをランダムに格納していく。
				danceKeyCodes[i] =
					CommandManager.Instance.danceButton[
						UnityEngine.Random.Range(0, CommandManager.Instance.danceButton.Length)];
			}

			for (int i = 0; i < CommandManager.Instance.commandNum; i++)
			{
				Debug.Log("Command : " + danceKeyCodes[i]);	
			}


			return danceKeyCodes;
		}
	}
}

