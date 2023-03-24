using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Template to destroy a power up object and apply its effect
public class PowerUpObject : MonoBehaviour
{
    public Powerup powerup; // Calls PowerAbstract.cs
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Checks if the colliding game object tag begins with "Player" (In this case it *IS* "Player")
        if (collision.gameObject.transform.tag.StartsWith("Player"))
        {
            // Assign variables to get the CharacterController2D component
            GameObject lilboy = collision.gameObject;
            CharacterController2D lilboyScript = lilboy.GetComponent<CharacterController2D>();
            
            // If the collided object is of the CharacterController2D class....
            if (lilboyScript)
            {
                //...destroy the power up sprite
                Destroy(gameObject);
                //...apply the power up effect to the object of the CharacterController2D class
                powerup.Apply(lilboyScript.gameObject); // Calls PowerAbstract.cs
            }
        }


         
    }
}
