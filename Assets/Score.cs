using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public int threeStars = 3;
    public int twoStars = 5;
    public Text scoreDisplay;
    public Animator scoreAnimator;
    public int nextLevel = 0;



    public void EndLevel()
    {
        Cannon cannon = FindObjectOfType<Cannon>();

        if (cannon)
        {
            int numProjectiles = cannon.numProjectiles;

            if (numProjectiles <= threeStars) 
            {
                GetComponent<Animator>();
         
                scoreAnimator.SetInteger("Stars",3);
                scoreDisplay.text = "3 stars";
            }
            else if (numProjectiles <= twoStars) 
            {
                GetComponent<Animator>();
                scoreAnimator.SetInteger("Stars", 2);
                scoreDisplay.text = " 2 stars ";
            }
            else 
            {
                GetComponent<Animator>();
                scoreAnimator.SetInteger("Stars", 1);
                scoreDisplay.text = " 1 star";
            }
           
            Invoke("NextLevel", 2);
        }

    }
    void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}

