using UnityEngine;
using UnityEngine.AI;

public struct EnemyAI
{
    public GameObject enemyObj;
    public Transform enemyTransform;
    public NavMeshAgent enemyAgent;
    public Animator enenyAnim;
    public float enemyHP;
    public float enemyAttack;
}

public struct BulletsStruct
{
    public GameObject bulletGameObject;
    public Transform bulletTransform;
    public float bulletDamage;
    public bool IsActived;
}
