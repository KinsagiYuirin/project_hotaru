using System;
using UnityEngine;
using UnityEngine.UIElements;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    private bool _escOn = true;
    private Vector3 _playerSpawn;
    [SerializeField] private GameObject player;

    private void Awake()
    {
        _playerSpawn = player.transform.position;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (_escOn)
        {
            Esc();
        }
        else
        {
            Disable();
        }
    }
    
    private void Pause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        _escOn = false;
    }
    
    public void Resume()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        _escOn = true;
    }
    
    public void Restart()
    {
        Time.timeScale = 1;
        player.transform.position = _playerSpawn;
        pauseMenu.SetActive(false);
        _escOn = true;
    }
    
    public void Quit()
    {
        Application.Quit();
    }

    private void Esc()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    private void Disable()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Resume();
        }
    }
}
