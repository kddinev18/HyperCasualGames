using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashaker : MonoBehaviour
{
    public IEnumerator Shake (float duration, float magnetude)
    {
        Vector2 originalPos = transform.localPosition;

        float elapsed = 0.0f;

        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnetude;
            float y = Random.Range(-1f, 1f) * magnetude;
            transform.localPosition = new Vector2(x, y);
            elapsed += Time.deltaTime;

            yield return null;
        }
        transform.localPosition = originalPos;

    }
}
