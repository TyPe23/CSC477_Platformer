using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Allows us to make multiple powerup objects with properties we can manipulate in unity editor; We can have variations of the same power up
[CreateAssetMenu(menuName = "Powerups/MoonBoots")]
 
public class MoonBoots : Powerup // Calls PowerUpObject
{
    public float new_jumpLimit;
    public override void Apply(GameObject target)
    {
        // Checks if target name begins with 'P' (Player) 
        if (target.ToString()[0] == 'P') {
            target.GetComponent<CharacterController2D>().maxJumps = new_jumpLimit;
        }

    }

                

}
