using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {
       
    }

 
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            StartCoroutine(FalseActive(.5f));
        }
        if (collision.gameObject.CompareTag("Platform"))
        {
           GetComponent<Rigidbody>().AddForce(transform.TransformDirection(-90, -90, 0) * .3f, ForceMode.Force);
        }
        if (collision.gameObject.CompareTag("Obs"))
        {
            StartCoroutine(FalseActive(.1f));
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Basket"))
        {
            print("Degdi");
            
        }
    }
    IEnumerator FalseActive(float second)
    {
       
        yield return new WaitForSeconds(second);
        gameObject.transform.localPosition = Vector3.zero;
        gameObject.transform.localRotation =Quaternion.Euler (Vector3.zero);
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent <Rigidbody>().angularVelocity = Vector3.zero;
        gameObject.SetActive(false);

    }
}
