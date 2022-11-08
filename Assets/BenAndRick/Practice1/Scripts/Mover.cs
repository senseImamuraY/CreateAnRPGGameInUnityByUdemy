using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  //Vector3 Pos = new Vector3(1, 0, 0);
  [SerializeField] float moveSpeed = 1f;
  // Start is called before the first frame update
  void Start()
  {
    PrintInstruction();
  }

  // Update is called once per frame
  void Update()
  {
    MovePlayer();
  }

  void PrintInstruction()
  {
    Debug.Log("Welcome to the game");
  }

  void MovePlayer()
  {
    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
    float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
    transform.Translate(xValue, 0, zValue);
  }
  private void FixedUpdate()
  {

  }
}
