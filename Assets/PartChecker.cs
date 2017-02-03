using UnityEngine;
using System.Collections;

namespace Main{
	public class PartChecker : MonoBehaviour {
		public GameObject[] itemsNeeded;

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
			bool isCorrect = true;
			bool isNotCorrect = false;
			int numberinneeded = itemsNeeded.Length;


			int numberwegot = 0;
			foreach(Transform thistransform in GameObject.FindGameObjectWithTag("Parts").transform){
				numberwegot++;
				bool foundthistransforminitemsneeded = false;



				foreach (GameObject thisgameobject  in itemsNeeded) {
					if (thisgameobject.name == thistransform.name) {
						foundthistransforminitemsneeded = true;

					}
				}
				if (foundthistransforminitemsneeded != true) {
					isCorrect = false;
					isNotCorrect = true;
				}

				print (thistransform.name + foundthistransforminitemsneeded);



			}

			if (isCorrect && !isNotCorrect && numberwegot == numberinneeded) {
				isCorrect = true;
				print ("what we got?  " + numberwegot);
				print ("what we need  " + numberinneeded);
			} else {
				isCorrect = false;

			}
			print ("Is Correct? " + isCorrect);


		



			//print (neededString);
			//print (gotString);

			print (isCorrect);

		}
	}
}
