using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

	public Animator anim;
	public GameObject openText;
	private bool isOpen = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (){
		if(isOpen == false){
			openText.SetActive (true);
		}
	
	}
	void OnTriggerExit (){
		openText.SetActive (false);

	}
	void OnTriggerStay (){
		if(Input.GetKeyDown("e")){
			anim.Play ("DoorOpen");
			openText.SetActive (false);
			isOpen = true;
		}
	}
}
