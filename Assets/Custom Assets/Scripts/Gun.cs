using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	ParticleSystem particleSystem;

	// Use this for initialization
	void Start(){
		particleSystem = transform.Find("Nozzle").GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update(){
		transform.localRotation = Camera.main.transform.localRotation;
	}
	
	
	public void Shoot(){		
		particleSystem.Emit(1);
	}
}
