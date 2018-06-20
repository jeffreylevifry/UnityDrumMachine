# UnityDrumMachine
16 step drum sequencer for mobile. Developed in Unity, styled after the early Roland series.

*Small issues I want to address:*

**The Clock**

Right now the clock is based on a loop that throws out signals on each downbeat. This works right now, but it does cause some small hiccups in rhythm. This was true of early drum machines, although they had more of a wavering inaccuracy in BPM rather than a hiccup. There are some other ways to build a clock that I might investigate. If anyone can improve on it, please let me know.


**BPM**

BPM is set to 100 BPM but can be changed manually via (Inspector Panel)SoundManager > Clock(Script). That is the variable to adjust if you would like to add an input. I will add one eventually.


**Drum Samples**

You can change the samples played in the SoundManager inspector panel.


**Audio Mixer**

Right now I have a compressor on the Audio Mixer master chain. It's difficult to get decent sound out of phone's native speakers, so if you want to crank the makeup gain there feel free. I had it up to about 10db on my phone and it was a little crunchy with the current samples. The setting I have it on now is fairly conservative.




