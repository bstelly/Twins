using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseGameEventOnTriggerEnter : MonoBehaviour
{
    [SerializeField, ChuTools.ScriptVariable("GameEvent")]    
    private GameEvent gameEvent;
    [Cinemachine.TagField]
    public string colliderTag;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(colliderTag))
        {
            gameEvent.Raise();
        }
    }
}
