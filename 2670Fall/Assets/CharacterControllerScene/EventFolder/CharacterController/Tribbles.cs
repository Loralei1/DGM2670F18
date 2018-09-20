using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using JetBrains.Annotations;
using UnityEngine;

public class Tribbles : MonoBehaviour
{

//	public GameObject[] Tribble;

	public GameObject Tribble;

	//public int tribblecount;

	public Transform transform;

	public List<GameObject> tribblecount;

	public GameObject AddMember;

	public int KirkAnnoyancePoints;


	IEnumerator Start()
	{
	
		while (tribblecount.Count <= 0)
		{
			yield return new WaitForSeconds(3);
			for (int i = 0; i < 1; i++)
			{
				Instantiate(Tribble, transform.position, transform.rotation);
			}
			tribblecount.Add (AddMember.gameObject);
			foreach (GameObject tribble in tribblecount) ;
		}


	}
}


//{Enemies.Add (AddMember.gameObject);

//foreach (GameObject Enemies in Enemies)
		
	//while (Tribble.Size > 0)
	//{
	//		yield return new WaitForSeconds(1);
	//		label.text = number.ToString();
	//		number--;
			
	//	}
	//	yield return new WaitForSeconds(1);
	//	label.text = "Go!";

	//}for (int i = 0; i < 1; i++) {
    
    //				Instantiate (Tribble, transform.position, transform.rotation);
    
  //  			}
    
    
    
    
    
    //	} 
    
    	

