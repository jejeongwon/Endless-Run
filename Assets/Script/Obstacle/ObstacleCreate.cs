using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obstacle;

    //InvokeRepeating : �� �� �Ŀ� �Լ��� ����ǰ� �� �� ���� �Լ��� �ݺ������� ����Ǵ� �Լ��̴�.
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
