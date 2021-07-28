using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBehavior : MonoBehaviour
{
    public int noteType;


    void Start()
    {
     
    }

    void Update()
    {
        transform.Translate(Vector3.down * GameManager.instance.noteSpeed);
        // 사용자가 노트 키를 입력한 경우
     
    }

    

}
