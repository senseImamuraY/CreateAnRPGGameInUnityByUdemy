using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PuyoController[] _puyoControllers = new PuyoController[2] { default!, default! };


    Vector2Int _position; // Ž²‚Õ‚æ‚ÌˆÊ’u
    // Start is called before the first frame update
    void Start()
    {
        _puyoControllers[0].SetPuyoType(PuyoType.Green);
        _puyoControllers[0].SetPuyoType(PuyoType.Red);

        _position = new Vector2Int(2, 12);

        _puyoControllers[0].SetPos(new Vector3((float)_position.x, (float)_position.y, 0.0f));
        _puyoControllers[1].SetPos(new Vector3((float)_position.x, (float)_position.y+1.0f, 0.0f));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
