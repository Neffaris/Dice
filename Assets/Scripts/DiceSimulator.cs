using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceSimulator : MonoBehaviour
{
    [SerializeField] Image _diceImg;
    [SerializeField] Sprite[] _diceSide;
    
    int DrawNumber()
    {
        int _randomNumber = Random.Range(0, _diceSide.Length);
        return _randomNumber;
    }

    public void ShowDrawResult()
    {
        _diceImg.sprite = _diceSide[DrawNumber()];
    }

    public void ApplicationExit()
    {
        Application.Quit();
    }
}
