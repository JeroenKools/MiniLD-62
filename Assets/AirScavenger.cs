using UnityEngine;
using System.Collections;

public class AirScavenger : MonoBehaviour {

	public float altitude;
	public float speed;
	
	GameObject defendTarget;
	Vector2 roamTarget;

	// Use this for initialization
	void Start(){
	
	}
	
	// Update is called once per frame
	void Update(){
		// Pick between Attack, Defend and Roam behaviors
	}
	
	
	void Attack(){
	
	}
	
	
	void Defend(){
		if(defendTarget == null) {
			// select a new resource to defend
		} else {
		
		}
	}
	
	
	void Roam(){
	
	}
}
