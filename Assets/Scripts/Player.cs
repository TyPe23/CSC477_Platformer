using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Player : MonoBehaviour {
  public Animator animator;
  public float speed;

  private CharacterController2D charCon;
  private float moveDir;
  private bool jump;

  private void Start() {
    charCon = GetComponent<CharacterController2D>();
    jump = false;
  }

  private void Update() {
    moveDir = Input.GetAxis("Horizontal");
    if (Input.GetKeyDown(KeyCode.Space)) {
      jump = true;
      animator.SetTrigger("Jump");
    }
    if (Input.GetKeyDown(KeyCode.K)) {
      animator.SetTrigger("Death");
    }
  }

  private void FixedUpdate() {
    charCon.Move(moveDir * speed * Time.fixedDeltaTime, false, jump);
    if (charCon.IsPlayerOnGround()) {
      animator.SetTrigger("Grounded");
    }
    jump = false;
    animator.SetFloat("Idle Run", Mathf.Abs(moveDir));
  }
}
