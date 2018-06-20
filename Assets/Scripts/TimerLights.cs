using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerLights : MonoBehaviour {

	public GameObject light1;
	public GameObject light2;
	public GameObject light3;
	public GameObject light4;
	public GameObject light5;
	public GameObject light6;
	public GameObject light7;
	public GameObject light8;
	public GameObject light9;
	public GameObject light10;
	public GameObject light11;
	public GameObject light12;
	public GameObject light13;
	public GameObject light14;
	public GameObject light15;
	public GameObject light16;

	public static TimerLights instance = null;

	void Awake ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
	}


	public void SendBeatNumber(int beatNumber){

		if (beatNumber==1){
			light16.SetActive (false);
			light1.SetActive (true);
		}
		if (beatNumber==2){
			light1.SetActive (false);
			light2.SetActive (true);
		}
		if (beatNumber==3){
			light2.SetActive (false);
			light3.SetActive (true);
		}
		if (beatNumber==4){
			light3.SetActive (false);
			light4.SetActive (true);
		}
		if (beatNumber==5){
			light4.SetActive (false);
			light5.SetActive (true);
		}
		if (beatNumber==6){
			light5.SetActive (false);
			light6.SetActive (true);
		}
		if (beatNumber==7){
			light6.SetActive (false);
			light7.SetActive (true);
		}
		if (beatNumber==8){
			light7.SetActive (false);
			light8.SetActive (true);
		}
		if (beatNumber==9){
			light8.SetActive (false);
			light9.SetActive (true);
		}
		if (beatNumber==10){
			light9.SetActive (false);
			light10.SetActive (true);
		}
		if (beatNumber==11){
			light10.SetActive (false);
			light11.SetActive (true);
		}
		if (beatNumber==12){
			light11.SetActive (false);
			light12.SetActive (true);
		}
		if (beatNumber==13){
			light12.SetActive (false);
			light13.SetActive (true);
		}
		if (beatNumber==14){
			light13.SetActive (false);
			light14.SetActive (true);
		}
		if (beatNumber==15){
			light14.SetActive (false);
			light15.SetActive (true);
		}
		if (beatNumber==16){
			light15.SetActive (false);
			light16.SetActive (true);
		}

	}
}
