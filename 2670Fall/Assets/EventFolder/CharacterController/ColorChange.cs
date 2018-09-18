using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {


		public enum gates {Gate, DeadGate, RedGate};

		public gates gatename; 

		
		void OnTriggerExit(Collider other) {

			switch (gatename)

			{case (gates.Gate):

					other.GetComponent<Renderer> ().material.color = GetComponent<Renderer> ().material.color;

					break;

				case (gates.RedGate):

					print ("Red.");

					break;

				case (gates.DeadGate):

					gameObject.SetActive(false);

					break; 

			}

			



		

		}

	

	}	