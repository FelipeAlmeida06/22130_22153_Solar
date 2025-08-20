using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource[] planetMusics; // arraste os AudioSources de cada planeta no inspetor

    // Toca apenas a música do planeta escolhido
    public void PlayPlanetMusic(int index)
    {
        // Para todas as músicas antes
        foreach (AudioSource audio in planetMusics)
        {
            audio.Stop();
        }

        // Toca apenas a música escolhida
        if (index >= 0 && index < planetMusics.Length)
        {
            planetMusics[index].Play();
        }
    }
}
