using UnityEngine;

public class PlayerController : PlayerCharacter, IPlayerMove
{
    private void FixedUpdate()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        _playerRb.velocity = Vector3.right * (_pSpeed * Time.deltaTime);
    }
}

