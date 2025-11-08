using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFish : MonoBehaviour
{

    //IMAGE VARIABLES
    public Sprite[] Sprites; // array of all sprites
    private SpriteRenderer _currentSprite;
    public RuntimeAnimatorController[] AnimationsController; // all animations for sprites (same indexes as sprites array)
    private Animator _currentAnimation;
    private int _currentIndex = 0; // current index of the sprites array


    //LOGISTICS VARIABLES
    private static int _stepValue = 3; // the exponential amount of extra exp needed to evolve
    private int _currentExpToEvolve = 40;
    private int _exp = 0; // how much exp the playerfish currently has


    // logic behind sprite evolution
    private void SpriteEvol()
    {

        // logic of evolution
        if (this._exp > this._currentExpToEvolve)
        {
            this._currentExpToEvolve *= _stepValue;
            _currentIndex += 1;
            // updates the sprites and animations
            this._currentSprite.sprite = Sprites[_currentIndex];
            this._currentAnimation.runtimeAnimatorController = AnimationsController[_currentIndex];
        }
    }

    public int GetCurrentIndex()
    {
        return this._currentIndex;
    }

    private static void DeadState()
    {
        SceneManager.LoadScene("DeadScene");
    }

    public void Reset()
    {
        this._exp = 0;
        this._currentIndex = 0;
        this._currentExpToEvolve = 40;
    }

    void OnTriggerEnter2D(Collider2D other) // collision with fish food to gain exp
    {
        GameObject otherGameObject = other.gameObject;

        if (other.gameObject.CompareTag("FishFood"))
        {
            //call Selena's function to return exp
            FishFood fishFood = otherGameObject.GetComponent<FishFood>();


            int fishExp = fishFood.GetXPToGive();
            fishFood.Disappear();


            this._exp += fishExp;
        }

        if (other.gameObject.CompareTag("FishHook"))
        {
            DeadState();
        }

    }

    void Start()
    {
        //sets the sprite to the first evolution upon start up
        this._currentSprite = GetComponent<SpriteRenderer>();
        this._currentAnimation = GetComponent<Animator>();
        this._currentSprite.sprite = Sprites[0];
        this._currentAnimation.runtimeAnimatorController = AnimationsController[0];
    }

    // Update is called once per frame
    void Update()
    {
        SpriteEvol();
    }

}