using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    //static : 로그램이 종료될때까지 메모리에서 살아있다.
    //static은 데이터 영역에 저장된다.

    public static GameManager instance;
    public float speed;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
