using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cocha3 : MonoBehaviour
{
    public Transform cochasss;
    public float AngularSpeed, RotationRadius;
    public float posX, posY, posZ, angle = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        posX = cochasss.position.x + Mathf.Cos(angle) * RotationRadius;
        posZ = cochasss.position.z + Mathf.Sin(angle) * RotationRadius;
        transform.position = new Vector3(posX, posY, posZ);

        angle = angle + Time.deltaTime * AngularSpeed;

        if (angle >= 360)
        {
            angle = 0;
        }
    }
}
