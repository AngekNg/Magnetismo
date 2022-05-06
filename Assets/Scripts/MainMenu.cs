using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void MenuScene() {
        SceneManager.LoadScene("MainMenu");
    }

    public void GameEscene(string nombreEscena) {
        SceneManager.LoadScene(nombreEscena);
    }

    public void Exit() {
        Application.Quit();
    }
}
