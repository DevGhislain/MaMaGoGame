//Using Unity System
using UnityEngine;

// Class for the Attack the player
public class MonsterBehaviour : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference of the GameObject for the Player 
    /// </summary>
    [SerializeField]
    private GameObject playerCharacter;

    /// <summary>
    /// Reference of the GameObject for the Ennemie 
    /// </summary>
    [SerializeField]
    private GameObject ennemieCharacter;

    /// <summary>
    /// Reference of the button for the Object GameOvers
    /// </summary>
    [SerializeField]
    private GameObject GameOvers;

    /// <summary>
    /// Reference of the button for the Object PauseBtn
    /// </summary>
    [SerializeField]
    private GameObject PauseBtn;

    /// <summary>
    /// Reference of the Animator for the Ennemie 
    /// </summary>
    [SerializeField]
    private Animator monsterAnimator;

    #endregion

    #region private Accessor Unity

    /// <summary>
    /// Reference of the state for monster
    /// </summary>
    private int state = 0;

    #endregion


    #region Method for the Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Update()
    {
        ennemieCharacter.transform.position = new Vector3(playerCharacter.transform.position.x - 5, playerCharacter.transform.position.y - 0.5f, -5);
    }

    #endregion

    #region Public Methods


    /// <summary>
    ///  Void of the no Attack the plyer
    /// </summary>
    public void GoFurther()
    {
        state--;
        monsterAnimator.SetInteger("State", state);
    }

    /// <summary>
    /// Void of the Attack the plyer
    /// </summary>
    public void GoCloser()
    {
        state++;
        monsterAnimator.SetInteger("State", state);
    }

    /// <summary>
    /// Reference of the OnCollisionExit2D for the Obstacle
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            Time.timeScale = 0;
            GameOvers.SetActive(true);
            PauseBtn.SetActive(false);

        }
    }

    #endregion

}
