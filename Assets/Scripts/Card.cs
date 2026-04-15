using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Card : MonoBehaviour
{
    RectTransform _rect;
    Transform _back; 
    Transform _front;

    void Awake()
    {
        _rect = GetComponent<RectTransform>();
        _back = transform.Find("Back");
        _front = transform.Find("Front");

    }
    // Update is called once per frame
    void Update()
    {
        if (_rect.localRotation.eulerAngles.y > 90 && _rect.localRotation.eulerAngles.y < 270)
        {
            _back.SetAsLastSibling(); // isso faz com que o back fique na frente do front, ou seja, o back fica visível e o front fica escondido
            // _back.gameObject.SetActive(false);
            // _front.gameObject.SetActive(true);
        }
        else
        {
            _front.SetAsLastSibling(); // isso faz com que o front fique na frente do back, ou seja, o front fica visível e o back fica escondido
            // _back.gameObject.SetActive(true);
            // _front.gameObject.SetActive(false);
        }

    }
}
