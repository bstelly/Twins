using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Luke
{
    public class Enemy : CharacterBehaviour
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private float _health;
        [SerializeField]
        private float _movementSpeed;
        public GameEvent onDeath;
        private NavMeshAgent navMesh;
        private Player target;

        private void Start()
        {
            target = FindObjectOfType<Player>();
            navMesh = GetComponent<NavMeshAgent>();
            _name = "Enemy";
            _health = 100;
            _movementSpeed = 20;
        }
        private void Update()
        {
            Move(target.transform.position);

            if(_health <= 0)
            {
                Die();
            }
        }

        public override string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public override float Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }

        public override float MovementSpeed
        {
            get
            {
                return _movementSpeed;
            }

            set
            {
                _movementSpeed = value;
            }
        }

        public override void Die()
        {
            onDeath.Raise();
            Destroy(this.gameObject);
        }

        public override void Move(Vector3 Direction)
        {
            Direction = navMesh.destination;
        }
    }
}
