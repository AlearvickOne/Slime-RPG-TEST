using UnityEngine;

public class EnemyAttack : AwakeMonoBehaviour
{
    private int ENEMY_ATTACK = Animator.StringToHash("EnemyAttack");
    private float _timerAttack = 4.5f;
    private static float _timerAttackStatic;

    private void Start()
    {
        _timerAttackStatic = _timerAttack;
    }

    private void Update()
    {
        for (int i = 0; i < _enemyAIStruct.Length; i++)
        {
            if (_enemyAIStruct[i].enemyObj.activeSelf == true)
                EnemyAttackPlayer(i);
        }
    }

    private void EnemyAttackPlayer(int i)
    {
        _timerAttack -= Time.deltaTime;

        float dist = Vector3.Distance(_enemyAIStruct[i].enemyTransform.position, _PCharacter._playerTransform.position);
        if (dist < 10 && dist > _enemyAIStruct[i].enemyAgent.stoppingDistance && _enemyAIStruct[i].enemyObj.activeSelf == true)
            _enemyAIStruct[i].enemyAgent.destination = _PCharacter._playerTransform.position;
        if (dist <= 1 && _enemyAIStruct[i].enemyObj.activeSelf == true && _timerAttack <= 0)
        {
            _enemyAIStruct[i].enenyAnim.SetTrigger(ENEMY_ATTACK);
            PlayerCharacter._playerHp -= _enemyAIStruct[i].enemyAttack;

            int ramdom = Random.Range(0, _TextDamageUp._textDamage.Length);
            _TextDamageUp._textDamageQuantity[ramdom].text = _enemyAIStruct[i].enemyAttack.ToString();
            _TextDamageUp._textDamage[ramdom].position = _PCharacter._playerTransform.position;

            _timerAttack = _timerAttackStatic;
        }
    }

}
