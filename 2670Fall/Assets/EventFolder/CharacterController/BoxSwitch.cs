using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSwitch : MonoBehaviour {


		
	
		public enum pickups {TransferPickUp, EnemyPickUp, DoorPickUp}

	
		public pickups pickupname;
		public PowerUp PowerUpTransfer;
		public int HitsTaken = 0;
		
		void OnTriggerExit(Collider obj) {

			switch (pickupname)

			{case (pickups.TransferPickUp):
			

					obj.GetComponent<MoveExample>().MovePattern = PowerUpTransfer.Transfer();
					break;

				case (pickups.EnemyPickUp):

					gameObject.SetActive(false);
					HitsTaken += 1;

					break;

				case (pickups.DoorPickUp):

					gameObject.SetActive(false);

					break; 

			}

			



		

		}

	

	}	