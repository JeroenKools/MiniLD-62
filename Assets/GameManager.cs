using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour {

	GameObject menu;
	Gun gun;
	FirstPersonController fpsController;
	
	public enum GameStates {
		Paused,
		Playing,
		Lost,
		Won
	}
	public static GameStates gameState;
	
	void Start(){
		menu = GameObject.Find("Canvas").transform.Find("Menu").gameObject;
		gun = GameObject.Find("Player/Gun").GetComponent<Gun>();
		fpsController = GameObject.Find("/Player").GetComponent<FirstPersonController>();
		
		Cursor.visible = false;
		gameState = GameStates.Playing;
	}
	
	// Update is called once per frame
	void Update(){		
	
		// Keys in menu
		if(gameState == GameStates.Paused) {
			if(Input.GetKeyDown(KeyCode.Escape)) {
				Continue();
			}
		}
		
		// Keys during gameplay
		else if(gameState == GameStates.Playing) {
			if(Input.GetKeyDown(KeyCode.Escape)) {
				ShowMenu();
			} else if(Input.GetButtonDown("Fire1")) {
				gun.Shoot();
			}
		}
	}
	
	
	public void Continue(){
		menu.SetActive(false);
		fpsController.enabled = true;
		gameState = GameStates.Playing;
	}
	
	
	public void ShowMenu(){
		menu.SetActive(true);
		fpsController.enabled = false;
		gameState = GameStates.Paused;
	}
	
	
	public void GoToOptions(){
 
	}
	
	
	public void GoToCredits(){
	
	}
	
	
	public static void Win(){
		if(gameState == GameStates.Playing) {
			print("You win!");
			gameState = GameStates.Won;
		}
	}
	
	
	public void Quit(){
		Application.Quit();
	}
}
