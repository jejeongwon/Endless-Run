using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleProperty : MonoBehaviour
{
    // Start is called before the first frame update
    
    private int value;
    public GameObject[] tireStack;//Ư���� ������ ������ �� �ִ�.

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

    //OnBecameInvisible :  ī�޶� ���ߴ� ȭ�� ������ �̺�Ʈ�� �ߵ��ϴ� �Լ��̴�.
    //MeshRender�� �ʿ��ϴ�.
    //private void OnBecameInvisible()

    
}
