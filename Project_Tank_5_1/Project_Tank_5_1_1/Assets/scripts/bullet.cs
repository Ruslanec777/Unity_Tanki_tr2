using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000000);
        //Destroy(gameObject);
    }
}
