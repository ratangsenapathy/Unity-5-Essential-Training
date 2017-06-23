using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour {

	// Use this for initialization
	public bool Chug;
	private Animator animator;
	private GameObject player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		animator = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider other)
	{
		animator.SetBool ("Chug", true);
	}

	void OnTriggerExit(Collider other)
	{
		animator.SetBool ("Chug", false);
	}
}
