using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanceScene
{
	public class CommandManager : SingletonMonoBehaviour<CommandManager>
	{

		public KeyCode[] danceButton;
		public int commandNum;
		
		// Use this for initialization
		void Start () 
		{
		
		}
	
		// Update is called once per frame
		void Update () 
		{
			if (Input.GetKeyDown(KeyCode.T))
			{
				CommandGenerator commandGenerator = new CommandGenerator();
				commandGenerator.GenerateCommand();
				Debug.Log("Debug");
			}
		}
	}	

}
