using UnityEngine;
using System.Collections;
namespace Main{
	public class ItemsTab : MonoBehaviour {
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
		
		}
		void OnMouseOver(){
			
			//ItemsTab.IsMouseOver = true;
			//GameTab.IsMouseOver = false;
		}

		public void PointerEnter(){
			
			ItemsTab.IsMouseOver = true;
			GameTab.IsMouseOver = false;
		}
		public void PointerExit(){
			ItemsTab.IsMouseOver = false;
			GameTab.IsMouseOver = true;

		}
	}
}
