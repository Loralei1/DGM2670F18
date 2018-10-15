using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Store", menuName = "Store/StoreFront")]
public class Store : ScriptableObject
{

	public Objects Available;
	public Objects Purchased; 
	
	public void MakePurchase(Object obj)
	{
		for (var index = 0; index < Available.ObjectList.Count; index++)
		{
			var availableObject = Available.ObjectList[index];
			if (availableObject == obj)
			{
				Purchased.ObjectList.Add(obj);
				Available.ObjectList.Remove(availableObject);
			}
		}
	}

}
