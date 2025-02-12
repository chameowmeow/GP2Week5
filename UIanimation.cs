using UnityEngine;

public class UIanimation : MonoBehaviour
{
    [SerializeField] private Animator uiPanel;
    [SerializeField] private Animator stagePanel;

    public void StageSelect()
    {
        uiPanel.SetTrigger("Started");

    }

    public void StageAnimation()
    {
        stagePanel.SetTrigger("Stage");
    }
}