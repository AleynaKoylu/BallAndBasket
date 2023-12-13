using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List <GameObject> Balls =new List<GameObject>();
    public GameObject ballPoint;
    public float force;
    int ballNumber=0;
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
                Balls[ballNumber].transform.SetPositionAndRotation(ballPoint.transform.position, ballPoint.transform.rotation);
                Balls[ballNumber].gameObject.SetActive(true);
                Balls[ballNumber].gameObject.GetComponent<Rigidbody>().AddForce(Balls[ballNumber].gameObject.transform.TransformDirection(90, 90, 0) * force, ForceMode.Force);
            if (Balls.Count - 1 == ballNumber)
                ballNumber = 0;
            else
                ballNumber++;
        }
    }
}
