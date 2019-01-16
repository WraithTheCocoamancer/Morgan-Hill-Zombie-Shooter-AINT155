using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Zombie Shooter Level clone");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Game Over_");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu_");
    }
}
