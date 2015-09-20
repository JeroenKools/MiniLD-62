using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

/// <summary>
/// Manages control of general game flow and stuff not directly related to player or boss
/// </summary>
public class GameManager : MonoBehaviour {

	GameObject menu;
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
		fpsController = GameObject.Find("/Player").GetComponent<FirstPersonController>();
		
		Cursor.visible = false;
		gameState = GameStates.Playing;
	}
	
	
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
			}
		}
	}
	
	
	public void Continue(){
		menu.SetActive(false);
		fpsController.enabled = true;
		gameState = GameStates.Playing;
		Cursor.visible = false;
	}
	
	
	public void ShowMenu(){
		menu.SetActive(true);
		fpsController.enabled = false;
		gameState = GameStates.Paused;
		Cursor.visible = true;
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
