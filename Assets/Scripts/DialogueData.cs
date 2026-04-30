using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Emart24_Dialogue", menuName = "Game/Emart24 Dialogue")]
public class DialogueData : ScriptableObject
{
    public string characterName = "гою╨";
    public List<DialogueLine> lines;
}

[System.Serializable]
public class DialogueLine
{
    [TextArea(2, 4)]
    public string text;
    public string[] choices = new string[3];
    public int[] affectionChange = new int[3];
}