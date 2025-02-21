using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject menuUI;
    public GameObject pausedUI;
    public GameObject gameUI;
    public GameStateManager gameStatemanager;

    public void EnableMenuUI()
    {
        DisableAllUI();
        menuUI.SetActive(true);
    }
    public void EnablePauseUI()
    {
        DisableAllUI();
        pausedUI.SetActive(true);
    }
    public void EnableGameUI()
    {
        DisableAllUI();
        gameUI.SetActive(true);
    }
    public void DisableAllUI()
    {
        menuUI.SetActive(false);
        pausedUI.SetActive(false);
        gameUI.SetActive(false);
    }
    public void StartOrResumeUI()
    {
        gameStatemanager.ChangeState(GameStateManager.GameState.Gameplay_State);
    }
    public void QuitUI()
    {
        Application.Quit();
    }
    public void GoToMenuUI()
    {
        gameStatemanager.ChangeState(GameStateManager.GameState.MainMenu_State);
    }
}
