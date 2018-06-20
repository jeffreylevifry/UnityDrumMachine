using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeatController : MonoBehaviour {
	List<string> beat1Sounds = new List<string>();
	List<string> beat2Sounds = new List<string>();
	List<string> beat3Sounds = new List<string>();
	List<string> beat4Sounds = new List<string>();
	List<string> beat5Sounds = new List<string>();
	List<string> beat6Sounds = new List<string>();
	List<string> beat7Sounds = new List<string>();
	List<string> beat8Sounds = new List<string>();
	List<string> beat9Sounds = new List<string>();
	List<string> beat10Sounds = new List<string>();
	List<string> beat11Sounds = new List<string>();
	List<string> beat12Sounds = new List<string>();
	List<string> beat13Sounds = new List<string>();
	List<string> beat14Sounds = new List<string>();
	List<string> beat15Sounds = new List<string>();
	List<string> beat16Sounds = new List<string>();

	[HideInInspector] public int clockBeat;
	int previousClockBeat =0;
	public string currentSound;

	public static BeatController instance = null;


	void Awake ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
	}

	void Start () {

	}
	

	void Update () {
		CheckForNewBeat ();
		
	}


	public void SelectBeatSound(int beatNumber, string selectedSound){
		if (beatNumber==1)
		{
			if (beat1Sounds.Contains(selectedSound)) {
				beat1Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (1);
			} else {
				beat1Sounds.Add(selectedSound);
				Debug.Log (beat1Sounds);
				BeatOnLightScript.instance.TurnOnLight (1);
			}

		}
		if (beatNumber==2)
		{
			if (beat2Sounds.Contains(selectedSound)) {
				beat2Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (2);
			} else {
				beat2Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (2);
			}

		}
		if (beatNumber==3)
		{
			if (beat3Sounds.Contains(selectedSound)) {
				beat3Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (3);
			} else {
				beat3Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (3);
			}

		}
		if (beatNumber==4)
		{
			if (beat4Sounds.Contains(selectedSound)) {
				beat4Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (4);
			} else {
				beat4Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (4);
			}

		}
		if (beatNumber==5)
		{
			if (beat5Sounds.Contains(selectedSound)) {
				beat5Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (5);
			} else {
				beat5Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (5);
			}

		}
		if (beatNumber==6)
		{
			if (beat6Sounds.Contains(selectedSound)) {
				beat6Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (6);
			} else {
				beat6Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (6);
			}

		}
		if (beatNumber==7)
		{
			if (beat7Sounds.Contains(selectedSound)) {
				beat7Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (7);
			} else {
				beat7Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (7);
			}

		}
		if (beatNumber==8)
		{
			if (beat8Sounds.Contains(selectedSound)) {
				beat8Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (8);
			} else {
				beat8Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (8);
			}

		}
		if (beatNumber==9)
		{
			if (beat9Sounds.Contains(selectedSound)) {
				beat9Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (9);
			} else {
				beat9Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (9);
			}

		}
		if (beatNumber==10)
		{
			if (beat10Sounds.Contains(selectedSound)) {
				beat10Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (10);
			} else {
				beat10Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (10);
			}

		}
		if (beatNumber==11)
		{
			if (beat11Sounds.Contains(selectedSound)) {
				beat11Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (11);
			} else {
				beat11Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (11);
			}

		}
		if (beatNumber==12)
		{
			if (beat12Sounds.Contains(selectedSound)) {
				beat12Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (12);
			} else {
				beat12Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (12);
			}

		}
		if (beatNumber==13)
		{
			if (beat13Sounds.Contains(selectedSound)) {
				beat13Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (13);
			} else {
				beat13Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (13);
			}

		}
		if (beatNumber==14)
		{
			if (beat14Sounds.Contains(selectedSound)) {
				beat14Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (14);
			} else {
				beat14Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (14);
			}

		}
		if (beatNumber==15)
		{
			if (beat15Sounds.Contains(selectedSound)) {
				beat15Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (15);
			} else {
				beat15Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (15);
			}

		}
		if (beatNumber==16)
		{
			if (beat16Sounds.Contains(selectedSound)) {
				beat16Sounds.Remove(selectedSound);
				BeatOnLightScript.instance.TurnOffLight (16);
			} else {
				beat16Sounds.Add(selectedSound);
				BeatOnLightScript.instance.TurnOnLight (16);
			}

		}
	
	}

	public void PlayBeatSounds(int beatNumber){

		if (beatNumber == 1) {

			foreach (string str in beat1Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 2) {

			foreach (string str in beat2Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 3) {

			foreach (string str in beat3Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 4) {

			foreach (string str in beat4Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 5) {

			foreach (string str in beat5Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 6) {

			foreach (string str in beat6Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 7) {

			foreach (string str in beat7Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 8) {

			foreach (string str in beat8Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 9) {

			foreach (string str in beat9Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 10) {

			foreach (string str in beat10Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 11) {

			foreach (string str in beat11Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 12) {

			foreach (string str in beat12Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 13) {

			foreach (string str in beat13Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 14) {

			foreach (string str in beat14Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 15) {

			foreach (string str in beat15Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}
		if (beatNumber == 16) {

			foreach (string str in beat16Sounds) {
				SoundManager.instance.FindSoundAndPlay (str);
			}
		}

	}
		

	void CheckForNewBeat(){
		if (clockBeat != previousClockBeat) {
		
			previousClockBeat = clockBeat;
			PlayBeatSounds (clockBeat);
	//		timer.text = clockBeat.ToString()+"/16";
			TimerLights.instance.SendBeatNumber(clockBeat);
		
		}
	}
}
