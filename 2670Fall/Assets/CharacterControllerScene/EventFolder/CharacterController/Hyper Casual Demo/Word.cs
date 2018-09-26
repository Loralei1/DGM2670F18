using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Word")]
public class Word : ScriptableObject
{
	public UnityEvent Solved;
	
	public string TheWord;

	public List<Letter> Value;

	public void Solving()
	{
		foreach (var letter in TheWord)
		{
			//mark as solved 
		}
	}
	
}
