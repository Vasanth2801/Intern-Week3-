using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource mainAudio,gunAudio,deathAudio,bossAudio,enemyAudio;
    public AudioClip mainClip,gunClip,deathClip,bossClip,enemyClip;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private void Start()
    {
        PlayMainMusic();
    }

    public void PlayMainMusic()
    {
        if (mainAudio != null && mainClip != null)
        {
            mainAudio.clip = mainClip;
            mainAudio.Play();
        }
    }

    public void PlayGunSound()
    {
        gunAudio.PlayOneShot(gunClip);
    }

    public void PlayDeathSound()
    {
        deathAudio.PlayOneShot(deathClip);
    }

    public void PlayBossDeath()
    {
        bossAudio.PlayOneShot(bossClip);
    }

    public void PlayEnemyDeath()
    {
        enemyAudio.PlayOneShot(enemyClip);
    }
}
