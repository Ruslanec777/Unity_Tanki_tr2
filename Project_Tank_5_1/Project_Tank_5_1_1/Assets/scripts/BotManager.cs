using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotManager : MonoBehaviour
{
    [SerializeField] private Transform _pointForRayCast;
    [SerializeField] private float _distancVision;
    [SerializeField] private float _smoothing;
    [SerializeField] private Transform _pivotTowerHullTankHoriztal;


    private PlayerManager _player;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerManager>();
    }

    private void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(_player.transform.position, _pointForRayCast.position, out hit, _distancVision))
        {

            Debug.Log("vision");

            //transform.position = Vector3.Lerp(transform.position, )
            Debug.DrawRay(_player.transform.position, _pointForRayCast.position, Color.red, _distancVision);

            //transform.position = Vector3.Lerp(transform.position, _player.transform.position, _smoothing * Time.deltaTime);
            
        }
        else
        {
            Debug.Log(" no vision");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //collision.gameObject.TryGetComponent<>
    }
}
