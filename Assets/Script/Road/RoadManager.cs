using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject road;
    public float speed;

    List<GameObject> roadList;
    int firstRoad;
    int lastRoad;

    Vector3 nextRoad = Vector3.zero;
   
    void Start()
    {
        roadList = new List<GameObject>();

        for(int i = 0; i < 5; i++)
        {
            roadList.Add(Instantiate(road, nextRoad, Quaternion.identity));
            nextRoad += Vector3.forward * 20;
        }
    }

    // Update is called once per frame
    void Update()
    {
       //i를 0으로 설정하는 이유는 [0]번째 index에 접근하기 위해서 초기화 한다.
        for(int i = 0; i < roadList.Count; i++)
        {
            roadList[i].transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if(roadList[lastRoad].transform.position.z <=-20)
        {
            firstRoad = lastRoad - 1;

            if(firstRoad <0)
            {
                firstRoad = roadList.Count - 1;
            }

            roadList[lastRoad].transform.position = roadList[firstRoad].transform.position + Vector3.forward * 20;

            lastRoad++;

            if(lastRoad >=roadList.Count)
            {
                lastRoad = 0;
            }
        }

    }
}
