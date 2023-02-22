using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
    
    public GameObject MainMenu;
    public GameObject ControlsMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void CreditsButton()
    {
        // Show Credits Menu
        MainMenu.SetActive(false);
        ControlsMenu.SetActive(true);
    }

    public void MainMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(true);
        ControlsMenu.SetActive(false);
    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
        Debug.Log("Game Quit");
    }
}

