using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    public int cooltime = 100;      // �K�E�Z�̃N�[���^�C��
    public int count = 0;           // �N�[���^�C���̃J�E���^
    public enum food_type
    {
        misokatu,
        uirou,
        BigEye,
    }

    public food_type food;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count++;
        if (count > cooltime)
        { // cooltime�����Ԃ��o������
            count = 0;
        }
    }

    public food_type GetFoodType()
    {
        return food;
    }
}
