using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour {

	public bool DoorCycle;
	private Animator animator;
	private GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		animator = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider other)
	{ 
		animator.SetBool ("DoorCycle", true);
	}

	void OnTriggerExit(Collider other)
	{
		animator.SetBool ("DoorCycle", false);
	}
}
