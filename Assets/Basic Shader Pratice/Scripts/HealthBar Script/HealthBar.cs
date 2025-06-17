using DG.Tweening;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthbarFillImg;
    [SerializeField] private Image healthbarTraillingFillImage;
    [SerializeField] private float trailDelay = 0.4f;

    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DrainHealthBar();
        }
    }

    private void DrainHealthBar()
    {
        currentHealth -= 10f;
        float ratio = currentHealth / maxHealth;

        Sequence _fillImgSequence = DOTween.Sequence();
        _fillImgSequence.Append(healthbarFillImg.DOFillAmount(ratio, 0.25f)).SetEase(Ease.InOutSine);
        _fillImgSequence.AppendInterval(trailDelay);
        _fillImgSequence.Append(healthbarTraillingFillImage.DOFillAmount(ratio, 0.3f)).SetEase(Ease.InOutSine);
        _fillImgSequence.Play();
    }



}

