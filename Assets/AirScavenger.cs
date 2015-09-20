using UnityEngine;
using System.Collections;

public class AirScavenger : MonoBehaviour {

	public float altitude;
	public float speed;
	public float shootInterval;
	
	GameObject defendTarget;
	Transform player;
	Transform turret;
	Vector2 roamTarget;
	ParticleSystem leftLaser;
	ParticleSystem rightLaser;
	float lastShot;

	// Use this for initialization
	void Start(){
		player = GameObject.Find("/Player").transform;
		turret = transform.Find("scavenger_air_main_group/scavenger_weapon_group/scavenger_air_gun");
		leftLaser = turret.Find("Default/LeftLaser").GetComponent<ParticleSystem>();
		rightLaser = turret.Find("Default/RightLaser").GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update(){
		if(GameManager.gameState == GameManager.GameStates.Playing) {
			// Pick between Attack, Defend and Roam behaviors
		
			Attack();
		}
	}
	
	
	void Attack(){
		AimTurrets();
		Shoot();
	}
	
	
	void Shoot(){
		if(Time.fixedTime - lastShot > shootInterval) {
			leftLaser.Emit(2);
			rightLaser.Emit(2);
			lastShot = Time.fixedTime;
		}
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
