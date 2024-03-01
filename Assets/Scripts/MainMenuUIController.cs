using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour
{
   public Button playButton;
    public Button exitButton;
    public Button creditsButton;

  private void Start()
  {
    playButton.onClick.AddListener(PlayGame);
    exitButton.onClick.AddListener(ExitGame);
    creditsButton.onClick.AddListener(Credits);
    
  }

  public void PlayGame()
  {
    SceneManager.LoadScene("Pinball");
  }

    private void ExitGame()
  {
    Application.Quit();
  }

  public void Credits() {
    SceneManager.LoadScene("Credits");
  }
}
