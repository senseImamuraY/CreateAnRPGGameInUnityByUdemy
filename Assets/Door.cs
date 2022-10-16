using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Door : MonoBehaviour, IPointerClickHandler
{
  public bool isOpen = false;
  public Box myBox;
  // Start is called before the first frame update
  void Start()
  {
    myBox = GameObject.Find("Cube").GetComponent<Box>();
  }

  // Update is called once per frame
  void Update()
  {
        
  }
  public void OnPointerClick(PointerEventData eventData)
  {
    if(isOpen == false && myBox.isOpen)
    {
      this.gameObject.transform.Rotate(new Vector3(0, 0, 200));
      isOpen = true;
    }
  }
}
