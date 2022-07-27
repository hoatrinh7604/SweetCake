using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI endGameTitle;
    [SerializeField] GameObject gameOver;
    [SerializeField] TextMeshProUGUI shuffe_tx;
    [SerializeField] Slider slider;
    // Start is called before the first frame update

    [SerializeField] GameObject confirm;

    void Start()
    {
        confirm.SetActive(false);
        gameOver.SetActive(false);
    }

    public void ShowConfirm()
    {
        Time.timeScale = 0;
        confirm.SetActive(true);
    }

    public void HideConfirm()
    {
        confirm.SetActive(false);
        Time.timeScale = 1;
    }

    public void BackToMenu()
    {
        GetComponent<SceneController>().BackToMenu();
    }

    public void GameOver(bool isWin)
    {
        gameOver.SetActive(true);

        endGameTitle.text = "Game over!!!";
        if (isWin) endGameTitle.text = "You win!!!";
    }

    public void UpdateRemainingShuffe(int value)
    {
        shuffe_tx.text = value.ToString();
    }

    public void SetSlider(float value)
    {
        slider.maxValue = value;
        slider.value = value;
    }

    public void UpdateSliderValue(float value)
    {
        slider.value = value;
    }
}
