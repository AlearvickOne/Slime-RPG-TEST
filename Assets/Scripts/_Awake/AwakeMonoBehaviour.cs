using UnityEngine;

public class AwakeMonoBehaviour : MonoBehaviour
{
    protected static TextDamageUp _TextDamageUp;
    protected static MoneySpritesInCoints _MoneySpritesInCoints;

    [Header("PlayerComponents")]
    protected static PlayerCharacter _PCharacter;

    [Header("EnemyComponents")]
    protected static EnemyAI[] _enemyAIStruct;

    [Header("AmmoComponents")]
    protected static BulletsStruct[] _bulletsStruct;
    protected static BulletsFireParabola _BullFire;
}
