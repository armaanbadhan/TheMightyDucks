using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text ScoreText;

    [SerializeField]
    private GameObject _instructions;

    public int score = 0;

    public void UpdateScore()
    {
        score += 10;
        ScoreText.text =  score + "";
    }

    public void HideInstructions()
    {
        _instructions.SetActive(false);
    }
}
