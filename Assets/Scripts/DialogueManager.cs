using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public GameObject choicePanel;
    public Button[] choiceButtons;

    private DialogueData currentData;
    private int currentIndex = 0;

    public void StartDialogue(DialogueData data)
    {
        currentData = data;
        currentIndex = 0;
        choicePanel.SetActive(false);
        ShowLine();
    }

    void ShowLine()
    {
        if (currentIndex >= currentData.lines.Count)
        {
            EndDialogue();
            return;
        }

        DialogueLine line = currentData.lines[currentIndex];
        nameText.text = currentData.characterName;
        dialogueText.text = line.text;

        if (line.choices[0] != "")
        {
            choicePanel.SetActive(true);
            for (int i = 0; i < choiceButtons.Length; i++)
            {
                if (i < line.choices.Length && line.choices[i] != "")
                {
                    choiceButtons[i].gameObject.SetActive(true);
                    choiceButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = line.choices[i];
                    int choice = i;
                    choiceButtons[i].onClick.RemoveAllListeners();
                    choiceButtons[i].onClick.AddListener(() => MakeChoice(choice));
                }
                else
                {
                    choiceButtons[i].gameObject.SetActive(false);
                }
            }
        }
        else
        {
            choicePanel.SetActive(false);
        }
    }

    public void MakeChoice(int choiceIndex)
    {
        // 호감도 변화 (나중에 연결)
        Debug.Log("선택지 " + choiceIndex + " 선택됨");

        currentIndex++;
        ShowLine();
    }

    void EndDialogue()
    {
        Debug.Log("대화 종료");
        // Panel_Store 닫기 또는 다음 대화로 넘어가기
    }
}