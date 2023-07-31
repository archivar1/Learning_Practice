using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  public float speed= 10f;
  public float jumpForce = 5f;
  public static bool onGround = true;
  private Rigidbody playerrb;
public CharacterController controller;
  void Start()
  {
    playerrb = GetComponent<Rigidbody>();
  }

    //Перемещение
    private void Update()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
      Vector3 move  = transform.right * x + transform.forward * z;
      controller.Move(move*speed*Time.deltaTime);

      if(Input.GetKeyDown(KeyCode.Space) && onGround)
      {
        playerrb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
        onGround = false;
      }
    }
private void OnCollisionEnter (Collision collision)
{
  if (collision.gameObject.name == "Plane")
   onGround = true; 
}
}