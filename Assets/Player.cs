using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static int power;
	Gun gun;

	// Use this for initialization
	void Start(){
		gun = GameObject.Find("Player/Gun").GetComponent<Gun>();
		power = 10;
	}
	
	// Update is called once per frame
	void Update(){
		if(GameManager.gameState == GameManager.GameStates.Playing) {
			if(Input.GetButtonDown("Fire1")) {
				gun.Shoot();
			}
		}
	}
	
	
	void OnParticleCollision(GameObject other){
		power = Mathf.Max(0, power - 1);
		print("Player was hit!");
	}
}
