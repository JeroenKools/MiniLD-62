using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public GameObject powerPrefab;
	public Color bossColor;
	public Color playerColor;
	
	GameObject bossPowerBar;
	GameObject playerPowerBar;
	Text playerTotalPower;
	Text bossTotalPower;
	GameManager gm;

	void Start(){
		bossPowerBar = transform.Find("BossHUDRow/PowerBar").gameObject;
		playerPowerBar = transform.Find("PlayerHUDRow/PowerBar").gameObject;
		bossTotalPower = transform.Find("BossHUDRow/TotalPwr").GetComponent<Text>();
		playerTotalPower = transform.Find("PlayerHUDRow/TotalPwr").GetComponent<Text>();
		gm = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	

	void Update(){
		if(Boss.power <= 0) {
			gm.Win();
		}
	
		UpdatePower(bossPowerBar, bossTotalPower, Boss.power, bossColor);
		UpdatePower(playerPowerBar, playerTotalPower, 10, playerColor);
	}
	
	void UpdatePower(GameObject powerBar, Text totalPower, int power, Color color){
		totalPower.text = power.ToString();
		for(int i=0; i<Mathf.Max(power, powerBar.transform.childCount); i++) {
			if(i >= power) {
				Destroy(powerBar.transform.GetChild(i).gameObject);
			} else if(i >= powerBar.transform.childCount) {
				GameObject powerBlock = (GameObject)Instantiate(powerPrefab, Vector3.zero, Quaternion.identity);
				powerBlock.name = string.Format("PowerBlock {0}", i);
				powerBlock.transform.parent = powerBar.transform;
				powerBlock.GetComponent<Image>().color = color;
			}
		}
	}
}
