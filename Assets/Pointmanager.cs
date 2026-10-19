using TMPro;
using UnityEngine;

public class Pointmanager : MonoBehaviour
{
    TMP_Text PointText;
    public int player1Score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PointText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        PointText.text = player1Score.ToString();
    }
}
