using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {


		//public enum gates {Gate, DeadGate, RedGate};
	
		public enum pickups {FlyPickUp, DiePickUp, DoorPickUp}

		//public gates gatename; 
		public pickups pickupname;
		
		void OnTriggerExit(Collider other) {

			switch (pickupname)

			{case (pickups.FlyPickUp):
				//case (gates.Gate):

					other.GetComponent<Renderer> ().material.color = GetComponent<Renderer> ().material.color;

					break;

				case (pickups.DiePickUp):

					print ("Red.");

					break;

				case (pickups.DoorPickUp):

					gameObject.SetActive(false);

					break; 

			}

			



		

		}

	

	}	