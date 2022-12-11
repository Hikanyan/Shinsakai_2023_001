using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : SingletonBehaviour<GameManager>
{
    [SerializeField] int maxScore = 99999999;
    int score = 0;
    [SerializeField] Text scoreText;
    [SerializeField] float waitTime = 2;
    [SerializeField] Text centerText;
    
    
    bool _gameStart = false;
    bool _gameOver = false;
    int _score = 0;
    protected override void OnAwake()
    {

    }
    private void Start()
    {
        
    }

    public IEnumerator GameStart()
    {
        yield return new WaitForSeconds(_waitTime);
        _centerText.enabled = true;
        _centerText.text = "3";
        yield return new WaitForSeconds(1);
        _centerText.text = "2";
        yield return new WaitForSeconds(1);
        _centerText.text = "1";
        yield return new WaitForSeconds(1);
        _centerText.text = "GO!!";
        yield return new WaitForSeconds(1);
        _centerText.text = "";
        _centerText.enabled = false;
    }
    public IEnumerator GameOver()
    {
        _gameOver = true;
        _centerText.enabled = true;
        _centerText.text = "Game Over";
        yield return new WaitForSeconds(_waitTime);
        _centerText.text = "";
        _centerText.enabled = false;
        _gameOver = false;
    }

    public int Score
    {
        set
        {
            _score = Mathf.Clamp(value, 0, _maxScore);
            _scoreText.text = _score.ToString("D8");
        }
        get
        {
            return _score;
        }
    }

}
