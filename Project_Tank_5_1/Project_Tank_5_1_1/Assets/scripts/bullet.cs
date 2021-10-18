using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    
    private void Awake()
    {
        SphereCollider sphereCollider = gameObject.GetComponent<SphereCollider>(); // может ли без этого работать ?;
        sphereCollider.isTrigger = true;
        Debug.Log(sphereCollider.ToString());
    }
    //private void Aw
    //{

    //}

    private void OnCollisionEnter(Collision collision) {


        //gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000000); // просто проверил возможность обратиться к компоненту
        //Destroy(gameObject);
        Debug.Log("OnCollision");
    }

    private void OnTriggerEnter(Collider other)
    {
         DamageForObject damageForObject = other.GetComponent<DamageForObject>();

        if (damageForObject != null)
        {
            Debug.Log("Hit WiTH BOT");
        }
    }
}
