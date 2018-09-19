using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ForEachLoop : ScriptableObject
{

	public List<FloatData> SpeedOptions;
	public FloatData RandomSpeed;

	private void OnEnable()
	{
		var randomNum = Random.Range(0, SpeedOptions.Count - 1);
		foreach (var floatData in SpeedOptions)
		{
			Debug.Log(floatData);
			//RandomSpeed = 
		}
	}
}
