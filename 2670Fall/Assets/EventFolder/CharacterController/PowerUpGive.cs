using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpGive : MonoBehaviour
{

	public class Trigger : MonoBehaviour
	{



		public PowerUp PowerUpTransfer;

		public GameObject other;

		public float PowerLevel;



		private void OnTriggerEnter(Collider obj)



		{

			obj.GetComponent<MoveExample>().MovePattern = PowerUpTransfer.Transfer();



			if (other.gameObject.CompareTag("Player"))
			{

				gameObject.SetActive(false);

			}

		}

	}
}

	
