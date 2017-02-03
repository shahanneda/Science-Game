using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Main{
	public class ButtonHandler : MonoBehaviour {
		private Button myButton;
		public GameObject MyObjectInGamePrefab;
		private GameObject myDescription;
		public GameObject myDescriptionHolder;
		float coolDown = 100;
		void OnEnable(){
			SetInitialReferences();
			coolDown = 100;
		}

		void OnDisable(){
			OnDelete ();
			//myDescription.SetActive(false);	
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
			OnDelete();
			gameObject.SetActive (false);
			GameObject objectInGame = Instantiate (MyObjectInGamePrefab) as GameObject;
			objectInGame.name = MyObjectInGamePrefab.name;
			objectInGame.transform.SetParent (GameObject.FindGameObjectWithTag("Parts").transform);
			objectInGame.GetComponentInChildren<PartHandler> ().isBeingDragged = true;
			objectInGame.GetComponentInChildren<PartHandler> ().myClone = gameObject;
			objectInGame.GetComponent<Canvas> ().worldCamera = Camera.main;

		}

		public void OnMouseEnter(){

			foreach (GameObject thisgameobject in GameObject.FindGameObjectsWithTag("Description")) {
				thisgameobject.SetActive(true);
				thisgameobject.transform.SetParent (thisgameobject.GetComponent<DescHandler> ().myParent.transform);
				thisgameobject.transform.SetSiblingIndex (0);
				thisgameobject.SetActive(false);


			}

			myDescription.transform.SetParent (myDescriptionHolder.transform);
			myDescription.SetActive(true);
			ItemsTab.IsMouseOver = true;

		}
		public void OnMouseExit(){
			myDescription.transform.SetParent (transform);
			myDescription.SetActive(false);
			ItemsTab.IsMouseOver = false;
		}

		public void OnDelete(){
			try {
				foreach (GameObject thisgameobject in GameObject.FindGameObjectsWithTag("Description")) {
					thisgameobject.SetActive(true);
					thisgameobject.transform.SetParent (thisgameobject.GetComponent<DescHandler> ().myParent.transform);
					thisgameobject.transform.SetSiblingIndex (0);
					thisgameobject.SetActive(false);


				}
			} catch (System.Exception ex) {
				
			}

		}
	}
}
