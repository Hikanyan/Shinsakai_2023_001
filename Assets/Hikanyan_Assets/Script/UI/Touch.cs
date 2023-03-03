using Hikanyan.Runner;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touch : MonoBehaviour
{
   
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Test);
    }

    void Test()
    {
        GameManager.Instance.GameStart = true;
    }
}
