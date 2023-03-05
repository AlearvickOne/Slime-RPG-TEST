using UnityEngine;

public class CanvasLookAtCamera : AwakeMonoBehaviour
{
    private Transform _camTransform;
    [SerializeField] private Transform _hpBar;
    private void Start()
    {
        _camTransform = Camera.main.transform.GetChild(0);
    }

    private void Update()
    {
        HPBarLookAtCamera();
    }

    private void HPBarLookAtCamera()
    {
        _hpBar.LookAt(_camTransform.transform);
    }
}
