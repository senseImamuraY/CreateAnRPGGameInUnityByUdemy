using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  //Vector3 Pos = new Vector3(1, 0, 0);
  // Start is called before the first frame update
  void Start()
  {
  // Translate‚ÍƒxƒNƒgƒ‹‚ð‘«‚·
    //transform.Translate(1, 0, 0);
  //this.transform.position = Pos;
}

  // Update is called once per frame
  void Update()
  {
    float xValue = Input.GetAxis("Horizontal");
    float zValue = Input.GetAxis("Vertical");
    transform.Translate(xValue, 0, zValue);
  }

  private void FixedUpdate()
  {

  }
}
