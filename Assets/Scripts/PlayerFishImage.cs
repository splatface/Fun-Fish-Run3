using UnityEngine;

public class PlayerFish : MonoBehaviour
{

    // sprite evolution cycle

    // current sprite icon equipped
    private SpriteRenderer _currentSprite;

    public Sprite[] sprites;

    void Start()
    {
        this._currentSprite = GetComponent<SpriteRenderer>();
        this._currentSprite.sprite = sprites[0];
    }
    public void SpriteEvol()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpriteEvol();
    }

}