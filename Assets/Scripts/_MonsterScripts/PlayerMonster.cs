using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Monster
{
	public class PlayerMonster : SingletonMonoBehaviour<PlayerMonster>
	{
		//Test
		//private void Awake()
		//{
		//	DontDestroyOnLoad(gameObject);
		//}
		//ここでMonsterを生成する処理
		//こオブジェクトになっているはずのMonsterPartsをまとめて拾って格納。

		public void gotoResultScene()
		{
			transform.position = new Vector3(-2.8f, 0, 0);
		}
	}	

}


