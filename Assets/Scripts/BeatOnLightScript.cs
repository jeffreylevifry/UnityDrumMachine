using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;   
using System;

public class BeatOnLightScript : MonoBehaviour {

	bool[] ActiveLights = new bool [16];
	public GameObject[] lights;
	public static BeatOnLightScript instance = null;
	string currentSound;

	void Awake ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);

	}
		

	void Start()
	{		
		ClearLights ();
		LoadPattern (currentSound);

	}


	public void LoadPattern(string newSound){
		ClearLights ();
		if (newSound == null) {
			return;
		} else {

			currentSound = newSound;
			if (PlayerPrefsX.GetBoolArray (currentSound).Length < 10) {
				return;
			} else {
				ActiveLights = PlayerPrefsX.GetBoolArray (currentSound);

				int i = 0;
				foreach (bool lightOn in ActiveLights) {
					i++;
					if (lightOn == true) {
						lights [i - 1].SetActive (true);
						Debug.Log ("on = " + i);
					}
					if (lightOn == false) {
						lights [i - 1].SetActive (false);
					}

				}
			}
		}

	}


	public void SavePattern(){
		PlayerPrefsX.SetBoolArray (currentSound, ActiveLights);
	}

	public void TurnOnLight(int position){
		ActiveLights[position-1] = true;
		lights [position-1].SetActive (true);
	}
	public void TurnOffLight(int position){
		ActiveLights[position-1] = false;
		lights [position-1].SetActive (false);
		Debug.Log ("turn off lights fired");
	}


	void ClearLights(){
		int i = 0;
		foreach (bool lightOn in ActiveLights) {
			i++;
			if ( lightOn == true){
				ActiveLights[i-1] = false;
				lights [i-1].SetActive (false);
			}
			if ( lightOn == false){
				lights [i-1].SetActive (false);
			}

		}
	}

	void RefreshLights(){
		int i = 0;
		foreach (bool lightOn in ActiveLights) {
			i++;
			if ( lightOn == true){
				ActiveLights[i-1] = true;
			}
			if ( lightOn == false){
				lights [i-1].SetActive (false);
			}

		}
	}


	void Update () {
		
	}
}
