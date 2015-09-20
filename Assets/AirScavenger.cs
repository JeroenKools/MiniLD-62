using UnityEngine;
using System.Collections;

public class AirScavenger : MonoBehaviour {

	public float altitude;
	public float speed;
	
	GameObject defendTarget;
	Transform player;
	Transform turret;
	Vector2 roamTarget;

	// Use this for initialization
	void Start(){
		player = GameObject.Find("/Player").transform;
		turret = transform.Find("scavenger_air_main_group/scavenger_weapon_group/scavenger_air_gun");
	}
	
	// Update is called once per frame
	void Update(){
		// Pick between Attack, Defend and Roam behaviors
		
		AimTurrets();
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
	
	
	void AimTurrets(){
		turret.LookAt(player.position);
	}
}
