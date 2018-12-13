using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ZachScripts
{
    public abstract class Ability
    {
        public string name;
        public float cooldown;
        public abstract void Activate();
    }
}