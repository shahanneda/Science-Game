using UnityEngine;
using System.Collections;

namespace Main{
	public class PartChecker : MonoBehaviour {
		public GameObject[] itemsNeeded;
		private string neededString;
		private string gotString;
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

		public void CheckForSubmit(){
			




			bool correct = true;
			bool foundItemInArray = true;
			bool ALLBREAKLOOSE = false;
			int counter = 0;
			foreach (Transform childTransform in transform) {
				counter++;

				foreach (GameObject item in itemsNeeded) {

					if (childTransform.name == item.name && foundItemInArray != false) {
						foundItemInArray = true;
						print ("Found that " + childTransform.name +"==" +item.name );
					}
					if (childTransform.name != item.name) {
						foundItemInArray = false;
						ALLBREAKLOOSE = true;
						print ("Found that " + childTransform.name +"!=" +item.name );
					}
				}

				//neededString += item.transform.name;
				if (!foundItemInArray || ALLBREAKLOOSE == true) {
					correct = false;
					print ("all hail broke loose" + ALLBREAKLOOSE);
				}
			}

			if (counter == 0) {
				correct = false;
			}


			print (correct);
			//print (neededString);
			//print (gotString);

			gotString = "";
			neededString = "";

		}
	}
}
