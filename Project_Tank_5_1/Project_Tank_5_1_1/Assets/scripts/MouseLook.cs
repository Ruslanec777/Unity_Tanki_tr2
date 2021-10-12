using System.Collections;
using System.Text;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxes axes = RotationAxes.MouseY;

    private StringBuilder _bufer = new StringBuilder("hello");

    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    private float _rotationX = 0f;

    private void Start()
    {
        StartCoroutine(ienumerCur());
    }



    void Update()
    {
        Debug.Log(_bufer);

        if (axes == RotationAxes.MouseX)
        {
            // это поворот в горизонтальной плоскости
            //transform.Rotate(0, sensitivityHor, 0);

            transform.Rotate(new Vector3(0f, Input.GetAxis("Mouse X") * sensitivityHor, 0));
        }
        else if (axes == RotationAxes.MouseY)
        {
            // это поворот в вертикальной плоскости
            Debug.Log($"transform.localEulerAngles.y = {transform.localEulerAngles.y}" + $"   transform.localEulerAngles.x = {transform.localEulerAngles.x}");

            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);

            //Debug.Log($"transform.localEulerAngles.y = {transform.localEulerAngles.y}" + $"   transform.localEulerAngles.x = {transform.localEulerAngles.x}");




        }
        else
        {
            // это комбинированный поворот

        }

    }

    public IEnumerator ienumerCur()
    {
        int count = 0;

        while (true)
        {
            Debug.Log(1);

            count++;
            _bufer = new StringBuilder( "строка из куратины " + count.ToString()) ;

            yield return null;


        }


    }
}
