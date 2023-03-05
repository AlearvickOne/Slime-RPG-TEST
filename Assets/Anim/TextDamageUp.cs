using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextDamageUp : AwakeMonoBehaviour
{
    [SerializeField] internal Transform[] _textDamage;
    [SerializeField] internal List<TMP_Text> _textDamageQuantity;

    private void Start()
    {
        _TextDamageUp = this.GetComponent<TextDamageUp>();
        for (int i = 0; i < _textDamage.Length; i++)
            _textDamageQuantity.Add(_textDamage[i].GetComponent<TMP_Text>());
    }

    private void Update()
    {
        TextDamageActiveUp();
    }

    private void TextDamageActiveUp()
    {
        for (int i = 0; i < _textDamage.Length; i++)
        {
            if (_textDamage[i].gameObject.activeSelf == true)
                _textDamage[i].transform.Translate(Vector3.up * 5 * Time.deltaTime);
        }
    }
}
