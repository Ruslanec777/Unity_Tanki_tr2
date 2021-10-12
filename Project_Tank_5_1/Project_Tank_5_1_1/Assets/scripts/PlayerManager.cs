using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour


{
    public float maxVerticalAngleBarrel;
    public float minVerticalAngleBarrel;

    [SerializeField] private Rigidbody _rigidbodey;
    [SerializeField] private float _speed = 100;
    [SerializeField] private float _speedAngle;
    [SerializeField] private float _speedAngleTower;
    [SerializeField] private Transform _transformPivotTowerHullTankHoriztal;
    [SerializeField] private Transform _transformPivotBarrelVertical;
    [SerializeField] private UnityEvent _shot;



    private bool _wForvardBool = false;
    private bool _sBackBool = false;
    private bool _moveLeft = false;
    private bool _moveRight = false;



    void Update()
    {
        _wForvardBool = Input.GetKey(KeyCode.W);
        _sBackBool = Input.GetKey(KeyCode.S);
        _moveLeft = Input.GetKey(KeyCode.A);
        _moveRight = Input.GetKey(KeyCode.D);



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _transformPivotTowerHullTankHoriztal.Rotate(Vector3.up * -_speedAngleTower * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            _transformPivotTowerHullTankHoriztal.Rotate(Vector3.up * _speedAngleTower * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //if (_transformPivotBarrelVertical.rotation.eulerAngles.x  >= minVerticalAngleBarrel)
            Debug.Log( ( (_transformPivotBarrelVertical.rotation.eulerAngles.x > 180f) ? _transformPivotBarrelVertical.rotation.eulerAngles.x -360f : _transformPivotBarrelVertical.rotation.eulerAngles.x).ToString()  +
                $">= { minVerticalAngleBarrel }");
            if (_transformPivotBarrelVertical.transform.rotation.eulerAngles.x >= minVerticalAngleBarrel | true)
            {
                _transformPivotBarrelVertical.Rotate(Vector3.right * -_speedAngleTower * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log( ( (_transformPivotBarrelVertical.rotation.eulerAngles.x > 180f) ? _transformPivotBarrelVertical.rotation.eulerAngles.x - 360f : _transformPivotBarrelVertical.rotation.eulerAngles.x).ToString() +
                $"<= {maxVerticalAngleBarrel + 360}");
            if (_transformPivotBarrelVertical.rotation.eulerAngles.x  >= maxVerticalAngleBarrel | true)
            {
                _transformPivotBarrelVertical.Rotate(Vector3.right * _speedAngleTower * Time.deltaTime);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _shot.Invoke();
        }

    }

    private void FixedUpdate()
    {
        if (_wForvardBool)
        {
            _rigidbodey.AddRelativeForce(Vector3.forward * _speed);
        }

        if (_sBackBool)
        {
            _rigidbodey.AddRelativeForce(Vector3.back * _speed);
        }

        if (_moveLeft)
        {
            _rigidbodey.AddRelativeTorque(Vector3.up * -_speedAngle);
        }

        if (_moveRight)
        {
            _rigidbodey.AddRelativeTorque(Vector3.up * _speedAngle);
        }


    }
}
