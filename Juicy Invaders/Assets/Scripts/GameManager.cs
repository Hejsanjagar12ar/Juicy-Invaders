using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;

[DefaultExecutionOrder(-1)]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private PlayerMovement player;
    private Invaders invaders;
    private Bunker[] bunkers;
    private CameraShake cameraShake;


    //Används ej just nu, men ni kan använda de senare
    public int score { get; private set; } = 0;
    public int lives { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        invaders = FindObjectOfType<Invaders>();
        bunkers = FindObjectsOfType<Bunker>();
        cameraShake = FindObjectOfType<CameraShake>();
        NewGame();
    }

    private void Update()
    {
        if (lives <= 0 && Input.GetKeyDown(KeyCode.Return))
        {
            NewGame();
        }
    }

    private void NewGame()
    {

        SetScore(0);
        SetLives(3);
        NewRound();
    }

    private void NewRound()
    {
        invaders.ResetInvaders();
        invaders.gameObject.SetActive(true);

        Respawn();
    }

    private void Respawn()
    {
        Vector3 position = player.transform.position;
        position.x = 0f;
        player.transform.position = position;
        player.gameObject.SetActive(true);
    }

    private void GameOver()
    {
        invaders.gameObject.SetActive(false);
    }

    private void SetScore(int score)
    {

    }

    private void SetLives(int lives)
    {
        lives = lives;
    }

    public void OnPlayerKilled(PlayerMovement player)
    {

        player.gameObject.SetActive(false);

    }

    public void OnInvaderKilled(Invader invader)
    {
        invader.gameObject.SetActive(false);

        StartCoroutine(cameraShake.Shake(0.5f, 0.2f));

        if (invaders.GetInvaderCount() == 0)
        {
            NewRound();
        }
    }

    public void OnBoundaryReached()
    {
        if (invaders.gameObject.activeSelf)
        {
            invaders.gameObject.SetActive(false);
            OnPlayerKilled(player);
        }
    }

}