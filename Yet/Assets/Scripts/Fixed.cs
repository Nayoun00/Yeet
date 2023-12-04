using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixed : MonoBehaviour
{

    public int targetWidth = 720; //���� �ػ�
    public int targetHeight = 1280; //���� �ػ�
    public bool fullscreen = true; //��ü ȭ�� ����

    void Start()
    {
        // ���ϴ� �ػ󵵷� ����
        Screen.SetResolution(targetWidth, targetHeight, fullscreen);
    }
}
