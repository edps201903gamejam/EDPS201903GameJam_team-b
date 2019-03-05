using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterParts
{
	public enum MONSTER_PARTS
	{
		//親オブジェクトから中心位置から
		//LeftなのかRightなのかを判定して生成時に情報をアタッチしてあげてほしい。
		LEFT_HAND,
		RIGHT_HAND,
		LEFT_FOOT,
		RIGHT_FOOT,
		LEFT_EYE,
		RIGHT_EYE,
		NOSE,
		LEFT_BROWS,
		RIGHT_BROWS,
		BODY,
		OTHER,
	}
}
