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
				//print ("MOUSE ENTER GAME TAB");

			} 

			if (ItemsTab.IsMouseOver) {
				//print ("MOUSE ENTER ITEM TAB");

			}
		}

		public void PointerEnter(){
			ItemsTab.IsMouseOver = false;
			GameTab.IsMouseOver = true;
		}
		public void PointerExit(){
			ItemsTab.IsMouseOver = true;
			GameTab.IsMouseOver = false;

		}

	}
}
