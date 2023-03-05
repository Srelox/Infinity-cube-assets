
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMscript : MonoBehaviour
{
    public bool gameHasEnded = false;

    public float restartDelay = 2f;
    // Update is called once per frame
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart",restartDelay);

            
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Score.globtimer = 0f;
    }
}
