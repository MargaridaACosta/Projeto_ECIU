using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barril3 : MonoBehaviour
{
    public float yPos { get; private set; }

    public Vector3 desiredPos;
    public float timer = 1f;
    public float timerSpeed;
    public float timeTomove;

    // Start is called before the first frame update
    void Start()
    {
        yPos = Random.Range(-0f, 10f);
        //  xPos = Random.Range(-4.5f, 4.5f);
        desiredPos = new Vector3(transform.position.x, yPos, transform.position.z);
    }

    // Update is called once per frame
    void Update(float speed)
    {
        timer += Time.deltaTime * timerSpeed;
        if (timer >= timeTomove)
     {
            transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * speed);
            if (Vector3.Distance(transform.position, desiredPos) <= 0.01f)
            {
                yPos = Random.Range(-0f, 10f);
                // xPos = Random.Range(-7f, 4.5f);
                desiredPos = new Vector3(transform.position.x, yPos, transform.position.z);
                timer = 0.0f;
            }
        }
    }
}
