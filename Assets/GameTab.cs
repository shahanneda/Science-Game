using UnityEngine;
using System.Collections;
namespace Main{
	public class GameTab : MonoBehaviour {
		public static bool IsMouseOver;
		void OnEnable(){
			SetInitialReferences();
		}

		void OnDisable(){

		}

		void SetInitialReferences(){

		}

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
			if (GameTab.IsMouseOver) {
				

			} 

			if (ItemsTab.IsMouseOver) {


			}
		}

		void OnMouseOver(){

			//GameTab.IsMouseOver = true;
			//ItemsTab.IsMouseOver = false;

		}

	}
}
