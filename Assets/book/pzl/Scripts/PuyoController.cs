using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PuyoType
{
    // enumを同時に数値としても扱える
    Blank = 0,

    Green = 1,
    Red = 2,
    Yellow = 3,
    Blue = 4,
    Purple = 5,
    Cyan = 6,

    Invalid = 7,
}

[RequireComponent(typeof(Renderer))]

public class PuyoController : MonoBehaviour
{
    static readonly Color[] color_table = new Color[] {
        Color.black,

        Color.green,
        Color.red,
        Color.yellow,
        Color.blue,
        Color.magenta,
        Color.cyan,

        Color.gray,
    };
    // null免除演算子を使用している.GetComponentを無くす
    [SerializeField] Renderer my_renderer = default!;
    //クラスの中でのみ参照するprivateなフィールドは変数名の頭に「アンダーバー」を付ける
    PuyoType _type = PuyoType.Invalid;

    public void SetPuyoType(PuyoType type)
    {
        _type = type;
        // キャストを使用している(int)
        my_renderer.material.color = color_table[(int)_type];
    }

    public PuyoType GetPuyoType()
    {
        return _type;
    }

    public void SetPos(Vector3 pos)
    {
        this.transform.localPosition = pos;
    }
}
