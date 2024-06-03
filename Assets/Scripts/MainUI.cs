using TMPro;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public TextMeshProUGUI GemText;

    public GameObject WinCanvas;
    public TextMeshProUGUI WinGemCount;

    public void UpdateGemCounter(int gemAmt)
    {
        GemText.text = gemAmt.ToString();
    }

    public void TriggerWinCanvas(int gemAmt)
    {
        WinCanvas.SetActive(true);
        WinGemCount.text = gemAmt.ToString();
    }
} 
