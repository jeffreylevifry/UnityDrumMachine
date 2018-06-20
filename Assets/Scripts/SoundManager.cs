using UnityEngine;
using System.Collections;


public class SoundManager : MonoBehaviour
{
	public AudioSource efxSource;
	//Drag a reference to the audio source which will play the sound effects.
	public AudioSource musicSource;
	//Drag a reference to the audio source which will play the music.
	public static SoundManager instance = null;
	//Allows other scripts to call functions from SoundManager.
	public float lowPitchRange = .95f;
	//The lowest a sound effect will be randomly pitched.
	public float highPitchRange = 1.05f;
	//The highest a sound effect will be randomly pitched.


	public AudioClip kick;
	public AudioClip snare;
	public AudioClip closedHat;
	public AudioClip mediumHat;
	public AudioClip openHat;
	public AudioClip cymbal;
	public AudioClip highTom;
	public AudioClip lowTom;
	public float snareVolume { get; set;}
	public float kickVolume { get; set;}
	public float closedHatVolume { get; set;}
	public float mediumHatVolume{ get; set;}
	public float openHatVolume { get; set;}
	public float cymbalVolume { get; set;}
	public float highTomVolume { get; set;}
	public float lowTomVolume { get; set;}


	void Awake ()
	{
		//Check if there is already an instance of SoundManager
		if (instance == null)
				//if not, set it to this.
				instance = this;
			//If instance already exists:
			else if (instance != this)
				//Destroy this, this enforces our singleton pattern so there can only be one instance of SoundManager.
				Destroy (gameObject);

		//Set SoundManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
		DontDestroyOnLoad (gameObject);
	}


	//Used to play single sound clips.
	public void PlaySingle (AudioClip clip)
	{
		//Set the clip of our efxSource audio source to the clip passed in as a parameter.
		efxSource.clip = clip;

		//Play the clip.
		efxSource.Play ();
	}

	public void FindSoundAndPlay(string selectedSound){
		if (selectedSound == "snare"){			
			efxSource.PlayOneShot (snare,snareVolume);
		}
		if (selectedSound == "kick"){			
			efxSource.PlayOneShot (kick,kickVolume);
		}
		if (selectedSound == "closedHat"){			
			efxSource.PlayOneShot (closedHat,closedHatVolume);
		}
		if (selectedSound == "mediumHat"){			
			efxSource.PlayOneShot (mediumHat,mediumHatVolume);
		}
		if (selectedSound == "openHat"){			
					efxSource.PlayOneShot (openHat,openHatVolume);
		}
		if (selectedSound == "cymbal"){			
					efxSource.PlayOneShot (cymbal,cymbalVolume);
		}
		if (selectedSound == "highTom"){			
					efxSource.PlayOneShot (highTom,highTomVolume);
		}
		if (selectedSound == "lowTom"){			
					efxSource.PlayOneShot (lowTom,lowTomVolume);
		}

		if (selectedSound == "kick"){			
					efxSource.PlayOneShot (kick,kickVolume);
		}
	}
}

