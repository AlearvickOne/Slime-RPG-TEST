using UnityEngine;

public class BulletsFireParabola : AwakeMonoBehaviour
{
    [SerializeField] private Transform _bulletTransform;
    [SerializeField] private float _bulletShotSpeed;
    [SerializeField] private float _timeDist;

    [Header("Positions")]
    [SerializeField] internal static Transform _pointA;
    [SerializeField] internal static Transform _pointB;
    [Space(10)]
    [Header("ParabolaFormul")]
    [SerializeField] private float _speedFastDown;
    private Vector3 _speedBeggining;
    private Vector3 _gravityVector;
    private Vector3 _currentAngle;

    private float dTime = 0;

    private void Start()
    {
        _BullFire = GetComponent<BulletsFireParabola>();
        _bulletTransform = transform;
        FireBulletsFormuleParabola();
    }

    private void FixedUpdate()
    {
        FireBulletActive();
    }

    private void FireBulletsFormuleParabola()
    {
        _gravityVector = Vector3.zero;
        _timeDist = Vector3.Distance(_pointA.position, _pointB.position) / _bulletShotSpeed;

        _bulletTransform.position = _pointA.position;

        _speedBeggining = new Vector3((_pointB.position.x - _pointA.position.x) / _timeDist,
                                       (_pointB.position.y - _pointA.position.y) / _timeDist - 0.5f * _speedFastDown * _timeDist,
                                       (_pointB.position.z - _pointA.position.z) / _timeDist);

    }

    private void FireBulletActive()
    {
        _gravityVector.y = _speedFastDown * (dTime += Time.fixedDeltaTime);

        _bulletTransform.position += (_speedBeggining + _gravityVector) * Time.fixedDeltaTime;
        _currentAngle.x = -Mathf.Atan((_speedBeggining.y + _gravityVector.y) / _speedBeggining.z) * Mathf.Rad2Deg;

        _bulletTransform.eulerAngles = _currentAngle;

    }

}
