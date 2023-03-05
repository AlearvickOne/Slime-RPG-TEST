using TMPro;
using UnityEngine;

public class PlayerBafs : AwakeMonoBehaviour
{
    [SerializeField] private PlayerAttack _attack;

    [SerializeField] private PlayerHpInSlider _playerHpInSlider;
    [Space(10)]
    [SerializeField] private TMP_Text _allMoney;
    [SerializeField] internal static int _allMoneyQuantity;
    [Space(10)]
    [SerializeField] private TMP_Text[] _moneyForPromotion;
    [SerializeField] private int[] _moneyForPromotionQuantity;

    private void Update()
    {
        _allMoney.text = _allMoneyQuantity.ToString();
        ParametersInText(0, _moneyForPromotion, _moneyForPromotionQuantity);
        ParametersInText(1, _moneyForPromotion, _moneyForPromotionQuantity);
        ParametersInText(2, _moneyForPromotion, _moneyForPromotionQuantity);
    }

    private void ParametersInText(int index, TMP_Text[] moneyProm, int[] moneyPromQuant)
    {
        moneyProm[index].text = moneyPromQuant[index].ToString();
    }

    public void ButtonPlayerBaffHP()
    {
        if (_allMoneyQuantity > _moneyForPromotionQuantity[0])
        {
            _allMoneyQuantity -= _moneyForPromotionQuantity[0];
            _moneyForPromotionQuantity[0] += 5;
            PlayerCharacter._playerSaveHp += 200;
            _playerHpInSlider._slider.maxValue = PlayerCharacter._playerSaveHp;
            PlayerCharacter._playerHp = PlayerCharacter._playerSaveHp;
        }
    }
    public void ButtonPlayerBaffSpeedAttack()
    {
        if (_allMoneyQuantity > _moneyForPromotionQuantity[1])
        {
            _allMoneyQuantity -= _moneyForPromotionQuantity[1];
            _moneyForPromotionQuantity[1] += 5;
            _attack._timerAttack -= 0.2f;
        }
    }

    public void ButtonPlayerBaffDamageAttack()
    {
        if (_allMoneyQuantity > _moneyForPromotionQuantity[2])
        {
            for (int i = 0; i < _bulletsStruct.Length; i++)
                _bulletsStruct[i].bulletDamage += 15;

            _allMoneyQuantity -= _moneyForPromotionQuantity[2];
            _moneyForPromotionQuantity[2] += 5;
        }
    }
}
