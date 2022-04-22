using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private PauseScreen pauseScreen;
    [SerializeField] Sprite[] _liveSprites;
    [SerializeField] Image livesImage;
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI restartText;
    private GameManager gm;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !pauseScreen.IsActive())
        {
            SetGameActive(false);
            pauseScreen.Open();
        }
    }

    private void Start()
    {
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    public void SetGameActive(bool active)
    {
        if (active)
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        } 
        
        else
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void updateLives(int currentLives)
    {
        IEnumerator GameOverFlicker()
        {
            while (currentLives == 0)
            {
                gameOverText.enabled = false;
                yield return new WaitForSeconds(0.5f);
                gameOverText.enabled = true;
                yield return new WaitForSeconds(0.5f);
            }
        }

        void GameOverSequence()
        {
            gameOverText.gameObject.SetActive(true);
            restartText.gameObject.SetActive(true);
            StartCoroutine(GameOverFlicker());
            gm.GameOver();

        }

        livesImage.sprite = _liveSprites[currentLives];
        if (currentLives == 0)
        {
            GameOverSequence();
        }
    }

    

    
}
