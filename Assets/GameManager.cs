using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour {

	GameObject menu;
	Gun gun;
	FirstPersonController fpsController;
	
	void Start(){
		menu = GameObject.Find("Canvas").transform.Find("Menu").gameObject;
		gun = GameObject.Find("Player/Gun").GetComponent<Gun>();
		fpsController = GameObject.Find("/Player").GetComponent<FirstPersonController>();
		
		print(menu + ", " + menu.activeInHierarchy);
	}
	
	// Update is called once per frame
	void Update(){		
	
		// Keys in menu
		if(menu.activeInHierarchy) {
			if(Input.GetKeyDown(KeyCode.Escape)) {
				Continue();
			}
		}
		
		// Keys during gameplay
		else {
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
	}
	
	
	public void ShowMenu(){
		menu.SetActive(true);
		fpsController.enabled = false;
	}
	
	
	public void Restart(){
	
	}
	
	
	public void GoToOptions(){
 
	}
	
	
	public void GoToCredits(){
	
	}
	
	
	public void Quit(){
		Application.Quit();
	}
}
