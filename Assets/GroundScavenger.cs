using UnityEngine;
using System.Collections;

public class GroundScavenger : MonoBehaviour {

	public float speed;
	public float turnSpeed;
	public int power;
	
	GameObject harvestTarget;
	Vector2 roamTarget;
	CharacterController cc;

	// Use this for initialization
	void Start(){
		power = 3;
		cc = transform.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update(){
		if(GameManager.gameState == GameManager.GameStates.Playing) {
			// Pick between Harvest, Roam and Attack behaviors
			Roam();
		}
	}
	
	/// <summary>
	/// Seek and collect resources
	/// </summary>
	void Harvest(){
		if(harvestTarget == null) {
			// Select a new harvest target
		}
	}
	
	
	/// <summary>
	/// Roam around. When it gets crowded and there are no resources or the player nearby.
	/// </summary>
	void Roam(){
		if(roamTarget == null) {
			// Select a new roam target
		}
		
		
		cc.Move(transform.TransformDirection(0, 0, Time.deltaTime * speed));
		transform.Rotate(0, Mathf.Sin(0.33f * Time.fixedTime) * Time.deltaTime * turnSpeed, 0, Space.World);
		
	} 
	
	
	/// <summary>
	/// Attack the player
	/// </summary>
	void Attack(){
		
	}
	
	
	void OnParticleCollision(GameObject other){
		power = Mathf.Max(0, power - 1);
		print("Scavenger was hit!");
	}
}
