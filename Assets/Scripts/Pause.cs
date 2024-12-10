using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (this.isPaused)
            {
                this.isPaused = false;
                Time.timeScale = 1.0f;
            } 
            else
            {
                this.isPaused = true;
                Time.timeScale = 0.0f;
            }
        }
    }
}
