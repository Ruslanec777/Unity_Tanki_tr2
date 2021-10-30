using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    private void Awake()
    {
        SphereCollider sphereCollider = gameObject.GetComponent<SphereCollider>(); // может ли без этого работать ?;
        //sphereCollider.isTrigger = true;
        Debug.Log(sphereCollider.ToString());
    }


    private void OnCollisionEnter(Collision collision)
    {
        DamageForObject damageForObject = collision.gameObject.GetComponent<DamageForObject>();
        //Destroy(gameObject);
        if (damageForObject)
        {
             Debug.Log("OnCollision");
            collision.gameObject.SendMessage("tebe uron");
            //Destroy(collision.gameObject);
            //Destroy(gameObject);
        }
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
