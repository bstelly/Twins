using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZachScripts
{
    public class PlayerShootingBehaviour : MonoBehaviour
    {
        public void FirePrimary(Vector3 direction)
        {
            this.transform.LookAt(new Vector3(direction.x,0,direction.z));
            Debug.Log("Rotating to " + direction);
            //have the player face that direction
            //call the weapons fire and fire in the direction of the stick
        }
    }
}