using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerGameOver : MonoBehaviour
{
    public Collider bola;
    // reference ke Canvas game over untuk mengaktifkannya saat game over terjadi
  public GameObject gameOverCanvas;

  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
			// disini game over canvas di aktifkan
      gameOverCanvas.SetActive(true);
    }
  }
}
