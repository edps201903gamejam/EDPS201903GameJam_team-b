using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using akazukin_omochabako;

namespace Monster
{
	public class Moster : MonoBehaviour
	{
		private void Awake()
		{
/*
			DontDestroyOnLoad(gameObject);
*/
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F1))
			{
				LoadScene.Instance.LoadStart();
			}
		}

		public void generate()
		{
			DontDestroyOnLoad(gameObject);
			LoadScene.Instance.LoadStart();
		}

		public void OnClick()
		{
			generate();
		}
	}	

}


