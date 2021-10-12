using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public Text myText, myText2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {
        Enemy.enemyKilled += updateScore;
        Player.jumped += updateJumps;
    }
    private void OnDisable()
    {
        Enemy.enemyKilled -= updateScore;
        Player.jumped -= updateJumps;
    }
    // Update is called once per frame
    void Update()
    {
        myText.text = PersistentManager.Instance.score.ToString();
        myText2.text = PersistentManager.Instance.numOfJumps.ToString();
    }

    private void updateScore()
    {
        PersistentManager.Instance.score++;
    }
    private void updateJumps()
    {
        PersistentManager.Instance.numOfJumps++;
    }
}
