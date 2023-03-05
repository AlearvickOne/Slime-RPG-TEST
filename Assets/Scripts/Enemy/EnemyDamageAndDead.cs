using UnityEngine;

public class EnemyDamageAndDead : AwakeMonoBehaviour
{
    private int _indexThisEnemy;

    private void Start()
    {
        FindComponents();
    }

    private void FindComponents()
    {
        for (int i = 0; i < _enemyAIStruct.Length; i++)
        {
            if (this.gameObject == _enemyAIStruct[i].enemyObj)
                _indexThisEnemy = i;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        EnemyDamage(other);
    }

    private void EnemyDamage(Collider other)
    {
        for (int i = 0; i < _bulletsStruct.Length; i++)
        {
            if (other.gameObject == _bulletsStruct[i].bulletGameObject && other.gameObject.activeSelf == true)
            {
                _enemyAIStruct[_indexThisEnemy].enemyHP -= _bulletsStruct[i].bulletDamage;

                int ramdom = Random.Range(0, _TextDamageUp._textDamage.Length);
                _TextDamageUp._textDamageQuantity[ramdom].text = _bulletsStruct[i].bulletDamage.ToString();
                _TextDamageUp._textDamage[ramdom].position = _enemyAIStruct[_indexThisEnemy].enemyTransform.position;

                if (_enemyAIStruct[_indexThisEnemy].enemyHP <= 0)
                {
                    _enemyAIStruct[_indexThisEnemy].enemyObj.SetActive(false);

                    int randomCointSprite = Random.Range(0, MoneySpritesInCoints._spriteMoney.Length);
                    if (MoneySpritesInCoints._spriteMoney[randomCointSprite].activeSelf == false)
                    {
                        MoneySpritesInCoints._spriteMoney[randomCointSprite].SetActive(true);
                        _MoneySpritesInCoints._spritesMoneyTF[randomCointSprite].position = _enemyAIStruct[_indexThisEnemy].enemyTransform.position;
                    }
                }

                _bulletsStruct[i].IsActived = true;
            }

        }
    }
}
