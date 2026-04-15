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
        RectTransform rect = card.transform as RectTransform; // pegamos o transform da carta e o transformamos em um RectTransform, para que possamos posicionar a carta dentro do holder

        rect.anchorMax = Holder.anchorMax; // definimos o anchorMax da carta para ser igual ao anchorMax do holder, para que a carta fique posicionada corretamente dentro do holder
        rect.anchorMin = Holder.anchorMin; // definimos o anchorMin da carta para ser igual ao anchorMin do holder, para que a carta fique posicionada corretamente dentro do holder
        rect.pivot = Holder.pivot; // definimos o pivot da carta para ser igual ao pivot do holder, para que a carta fique posicionada corretamente dentro do holder
        rect.SetParent(this.transform); // definimos o holder como pai da carta, para que a carta fique dentro do holder
        Vector3 targetPosition = Holder.anchoredPosition3D; // definimos a posição alvo da carta para ser a posição do holder, para que a carta fique posicionada corretamente dentro do holder

        rect.LeanMove(targetPosition, 1).setOnComplete(() =>
        { // movemos a carta para a posição do holder, usando o LeanTween para fazer uma animação suave 
            Cards.Add(card);
            card.transform.SetParent(Holder); // definimos o holder como pai da carta, para que a carta fique dentro do holder
            CardAmount.text = "" + Cards.Count;
        });
    }

    // método para remover uma carta do holder
    public void Remove(Card card)
    {
        Cards.Remove(card);
        CardAmount.text = string.Format("{0}", Cards.Count);
    }
}
