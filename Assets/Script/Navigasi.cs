using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Navigasi : MonoBehaviour
{
    public void GoTo()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void BackTo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void GoToOpening()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void GoToInstructions()
    {
        SceneManager.LoadScene(3);
    }
    public void GoToLearningGoals()
    {
        SceneManager.LoadScene(4);
    }
    public void GoToLearningActivity()
    {
        SceneManager.LoadScene(5);
    }
    public void GoToVocabulary()
    {
        SceneManager.LoadScene(6);
    }
    public void GoToReading()
    {
        SceneManager.LoadScene(7);
    }
    public void GoToVideo()
    {
        SceneManager.LoadScene(8);
    }
    public void GoToQuiz()
    {
        SceneManager.LoadScene(9);
    }
    public void GoToExit()
    {
        SceneManager.LoadScene(10);
    }
    public void Exit()
    {
     Application.Quit();
     Debug.Log("Anda Sudah Keluar");
    }
}