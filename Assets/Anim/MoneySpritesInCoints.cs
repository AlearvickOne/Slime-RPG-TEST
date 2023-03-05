using UnityEngine;

public class MoneySpritesInCoints : AwakeMonoBehaviour
{
    internal static GameObject[] _spriteMoney;
    internal int _moneyQuantity;

    [SerializeField] internal Transform[] _spritesMoneyTF;
    [Space(10)]
    [SerializeField] private Transform _allMoneyCoints;

    private void Awake()
    {
        _MoneySpritesInCoints = GetComponent<MoneySpritesInCoints>();
        _spriteMoney = new GameObject[_spritesMoneyTF.Length];

        for (int i = 0; i < _spritesMoneyTF.Length; i++)
        {
            _spriteMoney[i] = _spritesMoneyTF[i].gameObject;
            _spriteMoney[i].SetActive(false);
        }
    }

    private void Update()
    {
        MoneyInAllMoney();
    }

    private void MoneyInAllMoney()
    {
        for (int i = 0; i < _spritesMoneyTF.Length; i++)
        {
            if (_spriteMoney[i].activeSelf == true)
            {
                _spritesMoneyTF[i].position = Vector3.Lerp(_spritesMoneyTF[i].position, _allMoneyCoints.position, 5f * Time.deltaTime);
            }

            float dist = Vector3.Distance(_spritesMoneyTF[i].position, _allMoneyCoints.position);

            if (_spriteMoney[i].activeSelf == true && dist < 0.3f)
            {
                _moneyQuantity = Random.Range(50, 101);
                PlayerBafs._allMoneyQuantity += _moneyQuantity;
                _spriteMoney[i].SetActive(false);
            }
        }
    }
}
