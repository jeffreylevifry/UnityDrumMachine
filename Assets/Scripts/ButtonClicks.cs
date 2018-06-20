using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicks : MonoBehaviour {



	public string currentSound;



	public void SoundSelect(string selectedSound){
		BeatOnLightScript.instance.SavePattern ();
		currentSound = selectedSound;
		BeatOnLightScript.instance.LoadPattern (selectedSound);
		Debug.Log ("soundSelected = " + selectedSound);
	}

	public void BeatClick(int number){
		BeatController.instance.SelectBeatSound (number, currentSound);
		Debug.Log ("beat set  "+ currentSound+ " "+number);
	
	}
}
