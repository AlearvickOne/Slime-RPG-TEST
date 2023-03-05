using UnityEngine;

public class PlayerCharacter : AwakeMonoBehaviour
{
    internal Transform _playerTransform;
    internal Rigidbody _playerRb;

    internal static float _playerHp = 200;
    internal static float _playerSaveHp;

    internal static float _pSpeed = 400;
    internal static float _pSpeedConstStatic;

    private void Awake()
    {
        FindComponents();
    }

    private void FindComponents()
    {
        _PCharacter = GetComponent<PlayerCharacter>();
        _playerRb = GetComponent<Rigidbody>();
        _playerTransform = transform;

        _pSpeedConstStatic = _pSpeed;
        _playerSaveHp = _playerHp;
    }

}
