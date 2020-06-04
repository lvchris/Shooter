using UnityEngine;
using UnityEngine.UI;

public class ManageScore : MonoBehaviour
{
    public IntVariable m_score;
    public Text m_score_display;

    private void Awake()
    {
        m_score.value = 0;
    }

    public void ActualiseScore()
    {
        m_score_display.text = "Score : " + m_score.value.ToString();
    }
}
