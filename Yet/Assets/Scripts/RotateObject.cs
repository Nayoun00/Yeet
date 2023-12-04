using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField]

    private float rotateSpeed = -30f;    //�ð���� ����, �ݽð� ���

    void Start()
    {

    }
    void Update()
    {
        if (GameManager.Instance.isGameOver == false)
        {
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        }
    }
}
