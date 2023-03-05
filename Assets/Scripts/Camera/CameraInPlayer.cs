using UnityEngine;

public class CameraInPlayer : AwakeMonoBehaviour
{
    private Transform _camTransform;

    private void Start()
    {
        FindComponents();
    }

    private void FindComponents()
    {
        _camTransform = Camera.main.transform;
    }

    private void LateUpdate()
    {
        CameraInPlayerMethod();
    }

    private void CameraInPlayerMethod()
    {
        float posX = _PCharacter._playerTransform.position.x + 3;
        float posY = _camTransform.position.y;
        float posZ = _camTransform.position.z;
        _camTransform.position = new Vector3(posX, posY, posZ);
    }
}
