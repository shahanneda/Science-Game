using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
namespace Main{
	public class MainMenu : MonoBehaviour {


		public void GoToLevel(string level){
			UnityEngine.SceneManagement.SceneManager.LoadScene (level);

		}
	}
}
