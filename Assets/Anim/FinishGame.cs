using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : AwakeMonoBehaviour
{
    private string _playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_playerTag))
            SceneManager.LoadScene(0);
    }
}
