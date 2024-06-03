using UnityEngine;

public class CheckPointLantern : MonoBehaviour
{
    public GameObject m_DeactivatedSprite;
    public GameObject m_ActivatedSprite;

    private bool m_Activated = false;

    private void Start()
    {
        m_DeactivatedSprite.SetActive(true);
        m_ActivatedSprite.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (m_Activated)
            {
                return;
            }

            m_Activated = true;
            m_DeactivatedSprite.SetActive(false);
            m_ActivatedSprite.SetActive(true);

            Player player = collision.GetComponent<Player>();
            player.SetRespawnPoint(transform.position);
        }
    }
}
