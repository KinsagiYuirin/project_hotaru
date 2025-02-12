using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    private bool _escOn = true;
    
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
        _escOn = false;
    }
    
    public void Resume()
    {
        Time.timeScale = 1;
        _escOn = true;
    }
    
    public void BackToTitle()
    {
        Time.timeScale = 1;
        _escOn = true;
    }

    private void Esc()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
            pauseMenu.SetActive(true);
        }
    }

    private void Disable()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Resume();
            pauseMenu.SetActive(false);
        }
    }
}
