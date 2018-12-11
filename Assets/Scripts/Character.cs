using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public abstract string Name { get; set; }
    public abstract float Health { get; set; }
    public abstract float MovementSpeed { get; set; }
    public abstract void Move(Vector3 Direction);
    public abstract void Die();
}
