using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class ChangeColorOnTrigger : MonoBehaviour
{
	public ColorData SpriteColor; 
	private SpriteRenderer sRenderer;

	private void Start()
	{
		sRenderer = GetComponent<SpriteRenderer>();
		sRenderer.color = SpriteColor.Value; 
	}

	private void OnTriggerEnter(Collider obj)
	{
		obj.GetComponent<SpriteRenderer>().color = SpriteColor.Value; 
	}
}
