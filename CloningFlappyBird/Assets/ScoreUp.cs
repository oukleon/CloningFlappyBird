using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        Score.score++;
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    Score.score++;
    //}
}