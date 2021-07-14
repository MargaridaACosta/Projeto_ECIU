using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barril : MonoBehaviour
{
    public float horizontalspeed;
    public float verticalspeed;
   
    public Vector3 tempPosition;
    // Start is called before the first frame update
    void Start()
    {
        tempPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tempPosition.x = +horizontalspeed;
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalspeed);
        transform.position = tempPosition;
    }
}
