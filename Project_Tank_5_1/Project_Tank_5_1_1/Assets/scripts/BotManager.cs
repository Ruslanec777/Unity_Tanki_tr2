using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotManager : MonoBehaviour
{
   [SerializeField] private Transform _pointForRayCast;

    private PlayerManager _player;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerManager>();      
    }

    private void Update()
    {
        
    }
}
