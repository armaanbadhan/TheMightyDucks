using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text ScoreText;

    [SerializeField]
    private Text _displayScore;

    [SerializeField]
    private Sprite[] _livesSprite;

    [SerializeField]
    private Image _imageDisplay;

    private int _score = 0;

    public void UpdateLivesImage(int lives)
    {
        _imageDisplay.sprite = _livesSprite[lives];
    }

    public void UpdateScore()
    {
        _score += 10;
        ScoreText.text =  _score + "";
    }

    public void ResetScore()
    {
        _score = 0;
        ScoreText.text = _score + "";
    }

    public void DisplayScore()
    {
        _displayScore.text = "SCORE: " + _score;
    }

    public void HideScore()
    {
        _displayScore.text = "";
    }
}
