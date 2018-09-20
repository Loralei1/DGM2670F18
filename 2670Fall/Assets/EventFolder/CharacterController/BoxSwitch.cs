using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSwitch : MonoBehaviour {


		
	
		public enum pickups {TransferPickUp, Enemy, DoorPickUp}

	
		public pickups pickupname;
		public PowerUp PowerUpTransfer;
		public int HitsTaken = 0;
		
		void OnTriggerExit(Collider obj) {

			if (obj.gameObject.CompareTag("Player"))
			{

				switch (pickupname)

				{
					case (pickups.TransferPickUp):


						obj.GetComponent<MoveExample>().MovePattern = PowerUpTransfer.Transfer();
						break;

					case (pickups.Enemy):

						HitsTaken += 1;

						break;

					case (pickups.DoorPickUp):

						gameObject.SetActive(false);

						break;

				}
			}

		}

	}	