using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private GameObject highlight;

    public BaseEvent OccupiedEvent;
    public bool Walkable => OccupiedEvent == null;

    public void Init(bool isOffset)
    {
        renderer.color = isOffset ? offsetColor : baseColor;
    }

    private void OnMouseEnter()
    {
        highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        highlight.SetActive(false);
    }

    public void SetEvent(BaseEvent events) {
        if (events.OccupiedTile != null) events.OccupiedTile.OccupiedEvent = null;
        events.transform.position = transform.position;
        OccupiedEvent = events;
        events.OccupiedTile = this;
    }
}
