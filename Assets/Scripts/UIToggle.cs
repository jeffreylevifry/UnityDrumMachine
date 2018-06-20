using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIToggle : MonoBehaviour {

	public void ToggleInstrumentSelectButtonActive(){
		
		GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag ("InstrumentSelectionButton");

		foreach(GameObject go in gameObjectArray)
		{
			go.SetActive (false);
		}
		gameObject.SetActive(!gameObject.activeInHierarchy);
	
	}
}
