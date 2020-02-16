using UnityEngine;
using UnityEngine.UI;

public class TurboFanItem : MonoBehaviour
{
    public string _title, _details;
    public Text _titleText, _detailsText;
    public Canvas _canvas;

    public AudioClip clip;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = this.GetComponent<AudioSource>();
        if(clip)
        {
            audioSource.clip = clip;
        }
    }

    public void DisplayInformation()
    {
        _canvas.gameObject.SetActive(true);
        _titleText.text = _title;
        _detailsText.text = _details;
    }

    public void HideInformation()
    {
        _canvas.gameObject.SetActive(false);
    }

    public void PlayClip()
    {
        if (!clip || !audioSource) return;

        if (!audioSource.isPlaying)
            audioSource.Play();
        else
            audioSource.Stop();
    }

    public void StopClip()
    {
        if(audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
