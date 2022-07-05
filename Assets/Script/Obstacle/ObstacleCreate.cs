using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obstacle;

    //InvokeRepeating : 몇 초 후에 함수가 실행되고 몇 초 동안 함수가 반복적으로 실행되는 함수이다.
    void Start()
    {
        InvokeRepeating("Create", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Create()
    {
        Instantiate(obstacle, new Vector3(0, 0, 7.5f), Quaternion.identity);
    }
}
