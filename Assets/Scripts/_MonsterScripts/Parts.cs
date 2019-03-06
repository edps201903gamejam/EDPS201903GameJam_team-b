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

		private Transform defTransfrom;

		private void Awake()
		{
			DontDestroyOnLoad(this);
			setPartsType();
			defTransfrom = transform.parent.transform;
		}


		private void Update()
		{
			if(Input.GetKeyUp(KeyCode.P))
			{
				correctPosing();
			}
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

		public void resetPosing()
		{
			//transform.parent.transform.position = Vector3.zero;
			transform.parent.transform.eulerAngles = Vector3.zero;

			Debug.Log(defTransfrom.position);
		}


		//正解した時のポーズアクション
		public void correctPosing()
		{
			var defaultParentTransform = transform.parent.transform;
			var randomrot = Random.Range(-45.0f, 45.0f);
			if(_partsSide == PARTS_SIDE.HAVNT_NOT_DEFINE)
			{
				Debug.Log("左右判別なし");
				return;
			}
			else
			{
				transform.parent.transform.eulerAngles = new Vector3(0, 0, randomrot);
			}
		}

		//不正解時のポーズアクション。
		public void incorrectPosing()
		{
			var defaultParentTransform = transform.parent.transform;
			var randomrot = Random.Range(-45.0f, 45.0f);
			var randompos = Random.Range(-1.0f, 1.0f);
			if (_partsSide == PARTS_SIDE.HAVNT_NOT_DEFINE)
			{
				Debug.Log("左右判別なし");
				return;
			}
			else
			{
				transform.parent.transform.eulerAngles = new Vector3(0, 0, randomrot);
				//transform.parent.transform.position = new Vector3(0, 0, randompos);
				transform.parent.transform.right += new Vector3(randompos,0,0);
			}
		}

	}

	

}
