
using UnityEngine;
using UnityEngine.SceneManagement;   

public class LevelCompleted : MonoBehaviour
{
    public void Loadnextlevel(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
