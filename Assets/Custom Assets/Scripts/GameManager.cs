using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

/// <summary>
/// Manages control of general game flow and stuff not directly related to player or boss
/// </summary>
public class GameManager : MonoBehaviour {

	GameObject menu, winScreen, defeatScreen;
	Boss boss;
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
		winScreen = GameObject.Find("Canvas").transform.Find("Victory").gameObject;
		defeatScreen = GameObject.Find("Canvas").transform.Find("Defeat").gameObject;
		fpsController = GameObject.Find("/Player").GetComponent<FirstPersonController>();
		boss = GameObject.Find("/Boss").GetComponent<Boss>();
		
		Cursor.visible = false;
		gameState = GameStates.Playing;
	}
	
	
	void Update(){		
	
		if(gameState == GameStates.Playing) {
			Cursor.visible = false;
			fpsController.enabled = true;
		} else {
			Cursor.visible = true;
			fpsController.enabled = false;
		}
	
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
		gameState = GameStates.Playing;
	}
	
	
	public void ShowMenu(){
		menu.SetActive(true);
		gameState = GameStates.Paused;
	}
	
	
	public void GoToOptions(){
 
	}
	
	
	public void GoToCredits(){
	
	}
	
	
	public void Win(){
		if(gameState == GameStates.Playing) {
			gameState = GameStates.Won;
			winScreen.SetActive(true);
		}
	}
	
	
	public void Quit(){
		Application.Quit();
	}
}
