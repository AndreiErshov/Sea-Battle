using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class PlayClickHandler : MonoBehaviour, IPointerDownHandler
{
    private PlayMaker maker;
    public Sprite HitSprite;
    public Sprite LoseSprite;

    void Start()
    {
        this.maker = transform.parent.parent.gameObject.GetComponent<PlayMaker>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(transform.parent == maker.currentPlayer)
        {
            Image img = GetComponent<Image>();
            if(img.sprite != HitSprite && img.sprite != LoseSprite)
            {
                if(this.maker.MakeShot(transform.GetSiblingIndex()))
                {
                    img.sprite = HitSprite;
                } else
                {
                    img.sprite = LoseSprite;
                    this.maker.SwapPlayers();
                }
            }
        }
    }
}
