using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillAudio : MonoBehaviour
{
    private AudioSource killAudio;
    // Start is called before the first frame update
    void Start()
    {
        killAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        Enemy.enemyKilled += playKillAudio;
    }

    private void OnDisable()
    {
        Enemy.enemyKilled -= playKillAudio;
    }

    private void playKillAudio()
    {
        killAudio.Play();
    }
}
