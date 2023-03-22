using UnityEngine;

public class Parallax : MonoBehaviour {
  public float scale;
  public Transform tfPlayer;
  private float origXPos;

  private void Start() {
    origXPos = transform.position.x;
  }

  private void LateUpdate() {
    //transform.position = new Vector3((tfPlayer.position.x * scale), transform.position.y, transform.position.z);
    transform.position = new Vector3(origXPos - (tfPlayer.position.x * scale), transform.position.y, transform.position.z);
  }
}
