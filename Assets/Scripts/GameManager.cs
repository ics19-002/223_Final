using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    private bool isGameOver = false;
    private int score;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private SpawnManager sm;
    [SerializeField] private PlayerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && isGameOver == true)
        {
            SceneManager.LoadScene("MenuScene");
        }   
    }

    public void GameOver()
    {
        isGameOver = true;
        sm.spawn = false;
        pm.isActive = false;

        
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
