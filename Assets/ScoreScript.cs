using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    ScoreManager score;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        score.ScoreCalculator(10);
    }
}