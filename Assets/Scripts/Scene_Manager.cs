using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour {

    public void PlayScene() {

        SceneManager.LoadScene("GameScene");
    }

    public void Exit() {
        Application.Quit();
    }

    public void Credits() {
        SceneManager.LoadScene("Credits");

    }

    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");

    }

}
