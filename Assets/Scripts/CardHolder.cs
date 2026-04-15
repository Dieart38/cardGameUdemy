using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardHolder : MonoBehaviour
{
    public List<Card> Cards; // lista de cartas que estão no holder
    public Text CardAmount;// texto que mostra a quantidade de cartas que estão no holder
    public RectTransform Holder;  // transform do holder, para que as cartas possam ser posicionadas corretamente dentro do holder

    void Awake()
    {
        Cards = new List<Card>();
    }

    // método para adicionar uma carta ao holder
    public void Add(Card card)
    {
        Cards.Add(card);
        CardAmount.text = "" + Cards.Count;
    }

    // método para remover uma carta do holder
    public void Remove(Card card)
    {
        Cards.Remove(card);
        CardAmount.text = string.Format("{0}", Cards.Count);
    }
}
