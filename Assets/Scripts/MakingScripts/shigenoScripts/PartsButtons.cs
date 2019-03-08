using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace charamaking
{
	public class PartsButtons : MonoBehaviour
	{
		
		[SerializeField] private Sprite partsSprite;
		[SerializeField] private Sprite facePartsSprite;

		[SerializeField] private Sprite[] _parts;

		public void spliteChange()
		{
			if (CharaMakingManager.Instance.isSelectFace)
			{
				GetComponent<Image>().sprite = partsSprite;
			}
			else
			{
				GetComponent<Image>().sprite = facePartsSprite;
			}
		}
	}
}

