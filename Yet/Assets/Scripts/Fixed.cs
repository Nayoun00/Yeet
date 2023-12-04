using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixed : MonoBehaviour
{

    public int targetWidth = 720; //가로 해상도
    public int targetHeight = 1280; //세로 해상도
    public bool fullscreen = true; //전체 화면 여부

    void Start()
    {
        // 원하는 해상도로 설정
        Screen.SetResolution(targetWidth, targetHeight, fullscreen);
    }
}
