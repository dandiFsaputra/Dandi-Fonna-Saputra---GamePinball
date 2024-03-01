using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUIController : MonoBehaviour
{
    public Button mainMenuButton;

  private void Start()
  {
		// setup event saat button di klik
    mainMenuButton.onClick.AddListener(MainMenu);
  }

  public void MainMenu()
  {
		// kembali ke main menu
    SceneManager.LoadScene("Main Menu");
  }
}
