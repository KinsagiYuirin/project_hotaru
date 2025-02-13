using System;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject endGameUI;
    
    [SerializeField] private getFirefly _firefly;

    private void Start()
    {
        _firefly = FindObjectOfType<getFirefly>();
        endGameUI.SetActive(false);
    }

    private void Update()
    {
        if (_firefly.Firefly1)
        {
            EndGameUI();
        }
    }

    private void EndGameUI()
    {
        Time.timeScale = 0;
        endGameUI.SetActive(true);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
