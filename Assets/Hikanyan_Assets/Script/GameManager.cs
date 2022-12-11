using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : SingletonBehaviour<GameManager>
{

    [SerializeField]
    float waitTime = 2;
    [SerializeField]
    Text centerText;
    [System.NonSerialized]
    public bool gameOver = false;
    protected override void OnAwake()
    {

    }
    private void Start()
    {
        
    }

    public IEnumerator GameStart()
    {
        yield return new WaitForSeconds(waitTime);
        centerText.enabled = true;
        centerText.text = "3";
        yield return new WaitForSeconds(1);
        centerText.text = "2";
        yield return new WaitForSeconds(1);
        centerText.text = "1";
        yield return new WaitForSeconds(1);
        centerText.text = "GO!!";
        yield return new WaitForSeconds(1);
        centerText.text = "";
        centerText.enabled = false;
    }
    public IEnumerator GameOver()
    {
        gameOver = true;
        centerText.enabled = true;
        centerText.text = "Game Over";
        yield return new WaitForSeconds(waitTime);
        centerText.text = "";
        centerText.enabled = false;
        gameOver = false;
    }

}
