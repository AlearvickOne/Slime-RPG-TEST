using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FindEnemysAddStruct : AwakeMonoBehaviour
{
    private Transform _parentTransform;
    [SerializeField] private List<Transform> _enemys;
    private void Awake()
    {
        FindComponents();
        AddInStruct();
    }

    private void FindComponents()
    {
        _parentTransform = transform;
    }

    private void AddInStruct()
    {
        _enemyAIStruct = new EnemyAI[_parentTransform.childCount];

        foreach (Transform child in _parentTransform.GetComponentInChildren<Transform>())
            _enemys.Add(child);

        for (int i = 0; i < _parentTransform.childCount; i++)
        {

            int randomAttack = Random.Range(10, 21);
            int randomHP = Random.Range(50, 101);
            _enemyAIStruct[i].enemyObj = _enemys[i].gameObject;
            _enemyAIStruct[i].enemyTransform = _enemys[i].transform;
            _enemyAIStruct[i].enemyAgent = _enemys[i].GetComponent<NavMeshAgent>();
            _enemyAIStruct[i].enenyAnim = _enemys[i].GetComponentInChildren<Animator>();
            _enemyAIStruct[i].enemyHP = randomHP;
            _enemyAIStruct[i].enemyAttack = randomAttack;

        }
    }
}
