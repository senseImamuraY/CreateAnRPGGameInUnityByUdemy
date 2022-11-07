using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

public class Box : MonoBehaviour,IPointerClickHandler
{
  public bool isOpen = false;
  // Start is called before the first frame update
  void Start()
  {
        
  }

  // Update is called once per frame
  void Update()
  {
        
  }
  public void OnPointerClick(PointerEventData eventData)
  {
    if (isOpen == false)
    {
      this.gameObject.transform.Translate(new Vector3(-0.5f, 0, 0));
      isOpen = true;
    }
  }
}
