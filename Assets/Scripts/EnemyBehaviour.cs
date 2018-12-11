using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Luke
{
    public class EnemyBehaviour : CharacterBehaviour
    {
        private string _name;
        private float current_health = 100;
        private float _movementSpeed;
        public GameEvent onDeath;
        private NavMeshAgent navMesh;
        public Player target;

        private void Start()
        {
            target = FindObjectOfType<Player>();
            navMesh = GetComponent<NavMeshAgent>();
            _name = "Enemy";
        }
        private void Update()
        {
            navMesh.destination = target.transform.position;

            if(current_health <= 0)
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
                return current_health;
            }
            set
            {
                current_health = value;
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
            Destroy(gameObject);
        }

        public override void Move(Vector3 Direction)
        {
        }

        public override void TakeDamage(float amount)
        {
            if(current_health > 0)
            {
                ChangeHealth(-amount);
            }
        }

        public override void ChangeHealth(float amount)
        {
            current_health += amount;
        }

        public void OnTriggerStay(Collider other)
        {
            if(other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Enemy is Attacking");
                target.TakeDamage(20);
            }
        }
    }
}
