using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	ParticleSystem particleSystem;

	// Use this for initialization
	void Start(){
		particleSystem = transform.GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update(){
		//transform.parent.localRotation = Camera.main.transform.localRotation;
		Vector3 cameraAngle = Camera.main.transform.localRotation.eulerAngles;
		transform.parent.localRotation = Quaternion.Euler(-cameraAngle.x, cameraAngle.y + 180, cameraAngle.z);
	}
	
	
	public void Shoot(){		
		particleSystem.Emit(1);
	}
}
