using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    private AudioSource mainMenuButton;
    public AudioClip buttonAudio;

    void Start()
    {
        mainMenuButton = GetComponent<AudioSource>();
    }
    public void PlayGame()
    {
        mainMenuButton.PlayOneShot(buttonAudio, 1);
        //StartCoroutine(WaitTime(3));
        LifeManager.livesAmount = 3;
        CoinsManager.coin = 0;
        FlowersManager.flowerAmount = 0;
        //Scene 2 is Level 1
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        mainMenuButton.PlayOneShot(buttonAudio, 1);
        Application.Quit();
    }

    IEnumerator WaitTime(int second)
    {
        yield return new WaitForSeconds(second);
    }
}
