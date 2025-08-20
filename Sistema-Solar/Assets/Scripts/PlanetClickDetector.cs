using UnityEngine;

public class PlanetClickDetector : MonoBehaviour
{

    public int planetIndex; // defina no inspetor (0 = Mercúrio, 1 = Vênus, etc.)
    private AudioManager musicController;

    void Start()
    {
        musicController = FindObjectOfType<AudioManager>();
    }

    void OnMouseDown() // quando clicar no planeta
    {
        musicController.PlayPlanetMusic(planetIndex);
    }
}
