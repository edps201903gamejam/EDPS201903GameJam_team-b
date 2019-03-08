using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
namespace charamaking
{
	public class CharaMakingManager : SingletonMonoBehaviour<CharaMakingManager>
	{
		[HideInInspector] public bool isSelectFace;

		[SerializeField] public PartsButtons[] partsButtons;

		[SerializeField] public Button[] boxButtons;

		public int nowSelectState = 0;

		[Serializable]
		public class targetButton
		{
			public Sprite[] sprites;
			public void change()
			{
				for (int i = 0; i < Instance.boxButtons.Length;i++)
				{
					Instance.boxButtons[i].GetComponent<Image>().sprite = sprites[i];
				}
			}
		}

		[SerializeField] private List<targetButton> _targetButton = new List<targetButton>();

	}
}

