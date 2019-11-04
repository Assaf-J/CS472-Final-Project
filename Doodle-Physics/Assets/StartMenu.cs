using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
     public void NewGame()
     {
          SceneManager.LoadScene("Game");
     }
}
