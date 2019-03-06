using UnityEngine;
using UnityEngine.SceneManagement;

namespace akazukin_omochabako
{
	public class LoadScene : SingletonMonoBehaviour<LoadScene>
	{

		[SerializeField] private string LoadSceneName;
		
		public void LoadStart()
		{
			SceneManager.LoadScene(LoadSceneName);
		}
		
/*		public void LoadStart()
		{
			SceneManager.LoadScene(LoadSceneName);
		}*/
	}

}
