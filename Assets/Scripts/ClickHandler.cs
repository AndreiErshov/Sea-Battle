using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickHandler : MonoBehaviour, IPointerDownHandler
{
    private Sprite sprite;
    private ShipMakerSystem system;

    // Start is called before the first frame update
    void Start()
    {
        this.system = transform.parent.gameObject.GetComponent<ShipMakerSystem>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Image img = GetComponent<Image>();
        int index = transform.GetSiblingIndex();
        if(this.system.CheckPoint(index)) {
            if(img.sprite != null)
            {
                this.sprite = img.sprite;
                img.sprite = null;
                img.color = Color.blue;
                Debug.Log(index);
                this.system.game_grid.grid[index] = true;
            } else {
                if(this.sprite != null )img.sprite = this.sprite;
                img.color = Color.white;
                this.system.game_grid.grid[index] = false;
            }
        }
    }

}
