using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A "template" we can use to create multipl power ups
// The only thing this object does is create an Apply method, that applies the power up to the target (paddle) 

public abstract class Powerup : ScriptableObject
{
    public abstract void Apply(GameObject target);
} 
