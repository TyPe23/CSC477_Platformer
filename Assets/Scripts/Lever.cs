using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public bool flipped;
    public PlatformRetract[] activatePlatform;

    // Start is called before the first frame update
    void Start()
    {
        flipped = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        print(c.gameObject.tag);
        if (c.gameObject.CompareTag("attack"))
        {
            foreach (PlatformRetract platform in activatePlatform)
            {
                platform.togglePower();
            }

            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);


            // play some sound here
        }
    }
}
