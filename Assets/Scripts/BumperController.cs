using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
  public Collider bola;
  public float multiplier;
  public ScoreManager scoreManager;
  public float score;

  public AudioManager audioManager;
  public VfxManager vfxManager;



  private Animator animator;

  private void Start()
  {

    animator = GetComponent<Animator>();


  }

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.collider == bola)
    {
      Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
      bolaRig.velocity *= multiplier;

      animator.SetTrigger("Hit");



      //play sfx
      audioManager.PlaySFX(collision.transform.position);

      //play vfx
      vfxManager.PlayVFX(collision.transform.position);
            //tambah score saat menabrak bumper
      scoreManager.AddScore(score);
      
    }
  }
}