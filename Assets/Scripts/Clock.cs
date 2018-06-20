using UnityEngine;
using System.Collections;

// The code example shows how to implement a metronome that procedurally generates the click sounds via the OnAudioFilterRead callback.
// While the game is paused or the suspended, this time will not be updated and sounds playing will be paused. 
// Therefore developers of music scheduling routines do not have to do any rescheduling after the app is unpaused

[RequireComponent(typeof(AudioSource))]
public class Clock : MonoBehaviour
{
	 public double bpm = 70.0F;
	public float gain = 0.5F;
	public int signatureHi = 16;  //this is the length of the loop in beats
	public int signatureLo = 16;
	private double nextTick = 0.0F;
	private float amp = 0.0F;
	private float phase = 0.0F;
	private double sampleRate = 0.0F;
	private int accent;
	private bool running = false;
	void Start()
	{
		accent = signatureHi;
		double startTick = AudioSettings.dspTime;
		sampleRate = AudioSettings.outputSampleRate;
		nextTick = startTick * sampleRate;
		running = true;
	}

	void OnAudioFilterRead(float[] data, int channels)
	{
		if (!running)
			return;

		//double samplesPerTick = sampleRate * 60.0F / bpm * 4.0F / signatureLo;

		double samplesPerTick = sampleRate * 60.0F / bpm * 1.0F / signatureLo;
		double sample = AudioSettings.dspTime * sampleRate;
		int dataLen = data.Length / channels;
		int n = 0;
		while (n < dataLen)
		{
			float x = gain * amp * Mathf.Sin(phase);
			int i = 0;
			while (i < channels)
			{
				data[n * channels + i] += x;
				i++;
			}
			while (sample + n >= nextTick)
			{
				nextTick += samplesPerTick;
				amp = 1.0F;
				if (++accent > signatureHi)
				{
					accent = 1;
					amp *= 2.0F;
				}
				BeatController.instance.clockBeat = accent;
				//Debug.Log("Tick: " + accent + "/" + signatureHi+"  dspTime = "+AudioSettings.dspTime);
			}
			phase += amp * 0.3F;
			amp *= 0.993F;
			n++;
		}
	}
}