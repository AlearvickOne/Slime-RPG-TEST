using UnityEngine;

public class PlayerAttack : PlayerCharacter, IPlayerAttack
{
    internal float _timerAttack = 1.5f;
    private static float _startTimer;
    private static bool _firstAttack = false;

    private void Start()
    {
        _startTimer = _timerAttack;
    }

    private void Update()
    {
        if (_enemyAIStruct != null)
            PlayerDistanceEnemy();
    }

    public void PlayerDistanceEnemy()
    {

        for (int i = 0; i < _enemyAIStruct.Length; i++)
        {
            if (_firstAttack == false)
            {
                _timerAttack = 0;
                _firstAttack = true;
            }

            if (_enemyAIStruct[i].enemyObj.activeSelf == true)
            {
                float dist = 4f;
                float distantion = Vector3.Distance(_playerTransform.position, _enemyAIStruct[i].enemyTransform.position);

                if (distantion < dist)
                {
                    _pSpeed = 0;
                    PlayerAttackMethod(i);
                    break;
                }
                else if (distantion > dist)
                    _pSpeed = _pSpeedConstStatic;

            }

        }
    }
    public void PlayerAttackMethod(int i)
    {
        _timerAttack -= Time.deltaTime;

        for (int n = 0; n < _bulletsStruct.Length; n++)
        {
            if (_bulletsStruct[n].bulletGameObject == null)
                continue;

            if (_bulletsStruct[n].bulletGameObject.activeSelf == false && _timerAttack <= 0)
            {
                _bulletsStruct[n].bulletGameObject.SetActive(true);
                BulletsFireParabola._pointA = _playerTransform;
                BulletsFireParabola._pointB = _enemyAIStruct[i].enemyTransform;

                _timerAttack = _startTimer;
                break;
            }
        }

    }

}
