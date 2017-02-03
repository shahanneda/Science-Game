using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Main{
	public class ButtonHandler : MonoBehaviour {
		private Button myButton;
		public GameObject MyObjectInGamePrefab;
		private GameObject myDescription;
		float coolDown = 100;
		void OnEnable(){
			SetInitialReferences();
			coolDown = 100;
		}

		void OnDisable(){

		}

		void SetInitialReferences(){
			myButton = GetComponent<Button> ();
			myDescription = transform.GetChild (0).gameObject;
		}

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			if (coolDown != 0) {
				coolDown -= 10;

			}
		}

		public void Clicked(){
			if (coolDown != 0) {
				
				return;
			}
			ConvertToGameObject();
		}

		void ConvertToGameObject(){
			//MyObjectInGamePrefab.SetActive (true);
			gameObject.SetActive (false);
			GameObject objectInGame = Instantiate (MyObjectInGamePrefab) as GameObject;
			objectInGame.name = MyObjectInGamePrefab.name;
			objectInGame.transform.SetParent (GameObject.FindGameObjectWithTag("Parts").transform);
			objectInGame.GetComponentInChildren<PartHandler> ().isBeingDragged = true;
			objectInGame.GetComponentInChildren<PartHandler> ().myClone = gameObject;
			objectInGame.GetComponent<Canvas> ().worldCamera = Camera.main;

		}

		public void OnMouseEnter(){
			myDescription.SetActive(true);

		}
		public void OnMouseExit(){
			myDescription.SetActive(false);

		}
	}
}
