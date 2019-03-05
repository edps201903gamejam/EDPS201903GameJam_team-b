using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Monster;

namespace Monster
{
	public class Parts : MonoBehaviour {

		
		//オブジェクトにもともと持たせるパーツの種類。
		public MonsterParts.MONSTER_PARTS partsType;

		//左側のパーツなのか、右側のパーツなのか
		public enum PARTS_SIDE 
		{
			LEFT_PARTS,
			RIGHT_PARTS,
			HAVNT_NOT_DEFINE,
		}
		private Transform parentTransform;
		private PARTS_SIDE _partsSide;

		private void Awake()
		{
			DontDestroyOnLoad(this);
			setPartsType();
		}

		//座標から拾ってきてオブジェクトが左右のの情報を持つべきかどうかを判定する。
		public void setPartsType()
		{
			/*if(transform.parent == null)
			{
				Debug.LogError("深刻なエラーが発生しました。Monsterの実態となるオブジェクトが存在していないみたいです。");
				return;
			}*/
			
			if (!checkPartsType())
			{
				_partsSide = PARTS_SIDE.HAVNT_NOT_DEFINE;
				Debug.Log(gameObject.name+"は左右の情報が必要なオブジェクトではありません");
				return;
			}
			
			setSide();
			
		}

		public void testGetParts()
		{
			Debug.Log(partsType);
		}


		//パーツの種類を調べる。
		//パーツが左右の属性を持たないタイプのものであればfalse
		private bool checkPartsType()
		{
			if (partsType == MonsterParts.MONSTER_PARTS.NOSE || partsType == MonsterParts.MONSTER_PARTS.BODY ||
			    partsType == MonsterParts.MONSTER_PARTS.OTHER)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		
		public void setSide()
		{
			if (transform.position.x <= 0)
			{
				_partsSide = PARTS_SIDE.LEFT_PARTS;
			}
			else if (transform.position.x > 0)
			{
				_partsSide = PARTS_SIDE.RIGHT_PARTS;
			}
		}

	}

	

}
