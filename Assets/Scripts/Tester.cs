using UnityEngine;

public class Tester : MonoBehaviour
{
    public Card Card; // referência para a carta que queremos testar
    public CardHolder CardHolder; // referência para o holder que queremos testar

    [ContextMenu("Add Card")]
    public void AddCard()
    {
        CardHolder.Add(Card);
    }

    [ContextMenu("Remove Card")]
    public void RemoveCard()
    {
        CardHolder.Remove(Card);
    }

}
