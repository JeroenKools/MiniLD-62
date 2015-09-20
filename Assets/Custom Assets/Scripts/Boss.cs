using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	public enum BossStates {
		Attack,
		Wounded,
		Reboot
	}
	public static BossStates bossState;
	public static int power;

	// Use this for initialization
	void Start(){
		bossState = BossStates.Attack;
		power = 10;
	}
	
	// Update is called once per frame
	void Update(){
	
	}
	
	void OnParticleCollision(GameObject other){
		// TODO: make damage depend on player power
		power = Mathf.Max(0, power - 1);
		print("Boss was hit!");
	}
	
	
	void ToWounded(){
		// trigger attack-->wounded animation here
		bossState = BossStates.Wounded;
	}
	
	
	void ToReboot(){
		// trigger wounded-->reboot animation here
		bossState = BossStates.Reboot;
	}
	
	
	void ToAttack(){
		// trigger reboot-->attack animation here
		bossState = BossStates.Attack;
	}
	
	
	void Die(){
		// trigger death animation here
	}
}
