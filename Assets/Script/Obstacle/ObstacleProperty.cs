using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleProperty : MonoBehaviour
{
    // Start is called before the first frame update
    
    private int value;
    public GameObject[] tireStack;//특정한 갯수를 설정할 수 있다.

    void Start()
    {
        value = Random.Range(0, 3);

        for(int i = 0; i < tireStack.Length; i++)
        {
            tireStack[i].SetActive(false);
        }

        tireStack[value].SetActive(true);
    }




    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * GameManager.instance.speed * Time.deltaTime);

        if(transform.position.z <= -10f)
        {
            Destroy(gameObject);
        }
    }

    //OnBecameInvisible :  카메라가 비추는 화면 밖으로 이벤트를 발동하는 함수이다.
    //MeshRender가 필요하다.
    //private void OnBecameInvisible()

    
}
