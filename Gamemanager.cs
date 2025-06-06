using UnityEngine;
using UnityEngine.SceneManagement;  // Import SceneManagement to use SceneManager

public class GameManager : MonoBehaviour 
{
    bool gameHasEnded = false;  // Fixed variable name (no spaces allowed)
    public float restartDelay = 1f;
public GameObject completeLevelUI;
public void CompleteLevel ()
{
Debug.Log("LEVEL WON!");
completeLevelUI.SetActive(true);
}

    public void EndGame()
    {
        if (gameHasEnded == false)  // Use '==' to compare and no space in 'gameHasEnded'
        {
            gameHasEnded = true;
            Debug.Log("Ayush is a bad Driver");
            Invoke("Restart", restartDelay);  // Use restartDelay instead of hardcoding 2f
        }
    }

    void Restart()  // Parentheses are required for methods
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Fixed syntax error
    }
}
