using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _speedBullet;

    public void Shot()
    {
        GameObject bulletTemp = Instantiate(_bullet, transform);
        //bulletTemp.GetComponent<Rigidbody>().velocity = transform.forward * _speedBullet;
        bulletTemp.GetComponent<Rigidbody>().AddForce (transform.forward * _speedBullet);
        Destroy(bulletTemp, 30);
        transform.DetachChildren();
    }
}
 