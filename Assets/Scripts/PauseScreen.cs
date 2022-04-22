using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    [SerializeField] UIController ui;
    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public bool IsActive()
    {
        return gameObject.activeSelf;
    }

    public void OnReturnToGameButton()
    {
        Debug.Log("return to game");
        Close();
        ui.SetGameActive(true);
    }

    private void Update()
    {
        if (!gameObject.activeSelf)
        {
            OnReturnToGameButton();

        }

    }
}
