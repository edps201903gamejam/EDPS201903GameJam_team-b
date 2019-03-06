using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DanceScene
{
	public class CommandManager : SingletonMonoBehaviour<CommandManager>
	{
		public KeyCode[] danceButton;
		private KeyCode[] danceCommand;
		
		public int commandNum;
		
		// Use this for initialization
		void Start () 
		{
		
		}
	
		// Update is called once per frame
		void Update () 
		{
			//test
			if (Input.GetKeyDown(KeyCode.T))
			{
				commandGenerate();
			}
		}


		private void commandGenerate()
		{
			Array.Resize(ref danceCommand,commandNum);
			for (int i = 0; i < commandNum; i++)
			{
				var keyNum = Random.Range(0, danceButton.Length);
				Debug.Log(danceButton[keyNum]);
				danceCommand[i] = danceButton[keyNum];
				Debug.Log(danceCommand[i]);
			}
		}
	}	

}
