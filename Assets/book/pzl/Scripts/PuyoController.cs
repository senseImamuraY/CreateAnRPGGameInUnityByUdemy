using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PuyoType
{
    // enum�𓯎��ɐ��l�Ƃ��Ă�������
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
    // null�Ə����Z�q���g�p���Ă���.GetComponent�𖳂���
    [SerializeField] Renderer my_renderer = default!;
    //�N���X�̒��ł̂ݎQ�Ƃ���private�ȃt�B�[���h�͕ϐ����̓��Ɂu�A���_�[�o�[�v��t����
    PuyoType _type = PuyoType.Invalid;

    public void SetPuyoType(PuyoType type)
    {
        _type = type;
        // �L���X�g���g�p���Ă���(int)
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
