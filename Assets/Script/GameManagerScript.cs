using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class GameManagerScript : MonoBehaviour
{
    bool gameOver = false;
    public float restartDelay = 0.2f;
    public GameObject gameCompletedPanel;
    public SpriteRenderer endSprite;
    public float smoothing = 2f;

    public void CompleteLevel()
    {
        Debug.Log("Uhuhuhu end level");
        gameCompletedPanel.SetActive(true);
        loadNextLevel();
    }

    void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public IEnumerator ShowEndSprite()
    {
        Color spriteColor;
        spriteColor = endSprite.color;
        spriteColor.a = 0;

        while(endSprite.color.a < 255)
        {
            spriteColor.a += smoothing * Time.deltaTime;

            if (spriteColor.a > 255)
                spriteColor.a = 255;

            endSprite.color = spriteColor;
            yield return null;
        }

        

   

        print("Sprite rendered on alpha = 255 !");
        
    }

   

    public void EndGame()
    {
        if (gameOver == false)
        {
            gameOver = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().ToString());
        SceneManager.LoadScene(SceneManager.GetActiveScene().ToString());
    }
}
