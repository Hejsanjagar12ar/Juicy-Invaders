
using Unity.VisualScripting;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]

public class Invader : MonoBehaviour
{
    int enemyHealth = 10;
    public Sprite[] animationSprites = new Sprite[2];
    public float animationTime;

    SpriteRenderer spRend;
    int animationFrame;
    // Start is called before the first frame update

    //weapon dmg var
    int Gdmg = 1;
    int Sdmg = 1;
    int Admg = 1;
    int Bdmg = 1;
    int Ddmg = 1;

    private void Awake()
    {
        spRend = GetComponent<SpriteRenderer>();
        spRend.sprite = animationSprites[0];
    }

    void Start()
    {
        //Anropar AnimateSprite med ett visst tidsintervall
        InvokeRepeating(nameof(AnimateSprite), animationTime, animationTime);
    }

    //pandlar mellan olika sprited för att skapa en animation
    private void AnimateSprite()
    {
        animationFrame++;
        if (animationFrame >= animationSprites.Length)
        {
            animationFrame = 0;
        }
        spRend.sprite = animationSprites[animationFrame];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Bongo"))
        {
            enemyHealth -= Bdmg;
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Saxophone"))
        {
            enemyHealth -= Sdmg;
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Drum"))
        {
            enemyHealth -= Ddmg;
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Accordion"))
        {
            enemyHealth -= Admg;
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Guitar"))
        {
            enemyHealth -= Gdmg;
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Boundary")) //nått nedre kanten
        {
            GameManager.Instance.OnBoundaryReached();
        }
    }

    private void Update()
    {
        if (enemyHealth < 1)
        {
            GameManager.Instance.OnInvaderKilled(this);
        }
    }

}