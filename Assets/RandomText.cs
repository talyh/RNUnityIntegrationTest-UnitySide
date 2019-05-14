using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
{
    [SerializeField]
    private Text _display;

    private float _timer = 4;

    private void Start()
    {
        GenerateText();
    }

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > 2)
        {
            GenerateText();
            _timer = 0;
        }
    }

    private void GenerateText()
    {
        char[] letters = new char[4];

        for (int i = 0; i < 4; i++)
        {
            letters[i] = (char) Random.Range(65, 126);
        }

        _display.text = new string(letters);
    }
}