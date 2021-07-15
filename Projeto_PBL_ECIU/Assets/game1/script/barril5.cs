using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class barril5 : MonoBehaviour
{
    public Transform barril;
    public float AngularSpeed, RotationRadius;
    public float posX, posY, posZ, angle = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        posX = barril.position.x + Mathf.Cos(angle) * RotationRadius;
        posZ = barril.position.z + Mathf.Sin(angle) * RotationRadius;
        transform.position = new Vector3(posX, posY, posZ);

        angle = angle + Time.deltaTime * AngularSpeed;

        if (angle >= 360)
        {
            angle = 0;
        }
    }
}
