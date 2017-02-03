using UnityEngine;
using System.Collections;
namespace Main{
	public class PartHandler : MonoBehaviour {
		public bool isBeingDragged = true;
		public GameObject myClone;
		private GameObject myDescription;
		void OnEnable(){
			SetInitialReferences();
		}

		void OnDisable(){

		}

		void SetInitialReferences(){
			myDescription = transform.parent.GetChild (0).gameObject;
		}

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
			if(isBeingDragged){
				Vector3 newPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				newPos.z = transform.position.z;

				transform.position =newPos;
			}

		}



		void OnMouseDown(){
			
			if (isBeingDragged) {

				if (ItemsTab.IsMouseOver) {
					myClone.SetActive (true);
					gameObject.SetActive (false);
					Destroy (transform.parent.gameObject);

				}

			}
			isBeingDragged = !isBeingDragged;



		}



		public void OnMouseEnter(){
			myDescription.SetActive(true);

		}
		public void OnMouseExit(){
			myDescription.SetActive(false);

		}
	}
}
