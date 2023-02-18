using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadStartScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0);
    }

    public void LoadGreeting()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadDancing()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadExercise()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadSignLanguage()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadGreeting2()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadSignLanguage2()
    {
        SceneManager.LoadScene(6);
    }







    public void LoadStartSceneK()
    {
        //SceneManager.LoadScene(7);
    }

    public void LoadGreetingK()
    {
        SceneManager.LoadScene(7);
    }

    public void LoadDancingK()
    {
        //SceneManager.LoadScene(9);
    }

    public void LoadExerciseK()
    {
        //SceneManager.LoadScene(10);
    }

    public void LoadSignLanguageK()
    {
        SceneManager.LoadScene(9);
    }

    public void LoadGreeting2K()
    {
        SceneManager.LoadScene(8);
    }

    public void LoadSignLanguage2K()
    {
        SceneManager.LoadScene(10);
    }





    public void LoadJoy1()
    {
        SceneManager.LoadScene(11);
    }

    public void LoadJoy1yes()
    {
        SceneManager.LoadScene(12);
    }

    public void LoadJoy2()
    {
        SceneManager.LoadScene(13);
    }

    public void LoadJoy1no()
    {
        SceneManager.LoadScene(14);
    }




}
