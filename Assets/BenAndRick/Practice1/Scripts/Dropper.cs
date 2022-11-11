using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
  MeshRenderer renderer;
  Rigidbody rigidbody;
  [SerializeField] float waitTime = 5f;
  // Start is called before the first frame update
  void Start()
  {
    // 参照のキャッシュを使った。
    renderer = GetComponent<MeshRenderer>();
    rigidbody = GetComponent<Rigidbody>();

    renderer.enabled = false;
    rigidbody.useGravity = false;
  }

  // Update is called once per frame
  void Update()
  {
    if(Time.time > waitTime)
    {
      renderer.enabled = true;
      rigidbody.useGravity = true;
    }
  }
}
