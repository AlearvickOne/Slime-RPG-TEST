using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHpInSlider : AwakeMonoBehaviour
{
    [SerializeField] internal Slider _slider;

    private void Start()
    {
        _slider.maxValue = PlayerCharacter._playerHp;
    }

    private void Update()
    {
        HpInSlider();
    }

    private void HpInSlider()
    {
        _slider.value = PlayerCharacter._playerHp;

        if (_slider.value <= 0)
            SceneManager.LoadScene(0);
    }


}
