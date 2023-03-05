using System.Collections;
using UnityEngine;

public class SpawnBullets : AwakeMonoBehaviour
{
    [SerializeField] private Transform _spawnParent;
    [Space(10)]
    [SerializeField] private int _spawnQuantity;
    [SerializeField] private GameObject _spawnObject;

    private void Awake()
    {
        StartSpawnBullets();
        StartCoroutine(IDestroyBullet());
    }

    private void StartSpawnBullets()
    {
        _bulletsStruct = new BulletsStruct[_spawnQuantity];

        for (int i = 0; i < _spawnQuantity; i++)
        {
            GameObject spawnObj = Instantiate(_spawnObject, _spawnParent.position, Quaternion.identity);
            _bulletsStruct[i].bulletGameObject = spawnObj;
            _bulletsStruct[i].bulletTransform = spawnObj.transform;
            _bulletsStruct[i].bulletDamage = 25f;
            _bulletsStruct[i].IsActived = false;

            _bulletsStruct[i].bulletTransform.parent = _spawnParent;
            _bulletsStruct[i].bulletGameObject.SetActive(false);
        }
    }

    private IEnumerator IDestroyBullet()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            for (int i = 0; i < _bulletsStruct.Length; i++)
            {
                if (_bulletsStruct[i].IsActived == true)
                    Destroy(_bulletsStruct[i].bulletGameObject);
            }
        }
    }
}
