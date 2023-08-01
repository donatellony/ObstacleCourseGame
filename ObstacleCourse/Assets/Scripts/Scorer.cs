using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;
    private void Start()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        ++score;
        ShowScore();
    }

    private void ShowScore()
    {
        Debug.Log($"You've bumped into the things {score} times now!");
    }
}
