using UnityEngine;
using UnityEngine.UI;

public class EnemyHpInSlider : AwakeMonoBehaviour
{
    [SerializeField] private Slider _hpEnemySlider;
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
        _hpEnemySlider.maxValue = _enemyAIStruct[_indexThisEnemy].enemyHP;
    }

    private void Update()
    {
        HpEnemyInSlider();
    }

    private void HpEnemyInSlider()
    {
        _hpEnemySlider.value = _enemyAIStruct[_indexThisEnemy].enemyHP;
    }

}
