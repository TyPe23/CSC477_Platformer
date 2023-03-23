using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRetract : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    private Vector3 origPos;
    public bool poweredOn;
    private bool moveLeft;
    private bool moveRight;
    private float moveDist = 8f;
    

    // Start is called before the first frame update
    void Start()
    {
        origPos = transform.position;
        moveLeft = true; 
        moveRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (poweredOn)
        {
            if (moveLeft)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                if (transform.position.x <= origPos.x - moveDist)
                {
                    moveLeft = false;
                    moveRight = true;
                }
            }
            if (moveRight)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                if (transform.position.x >= origPos.x)
                {
                    moveLeft = true;
                    moveRight = false;
                }
            }
        }
    }

    public void resetPos()
    {
        transform.position = origPos;
        poweredOn = false;
    }

    public void togglePower()
    {
        poweredOn = !poweredOn;
    }
}
