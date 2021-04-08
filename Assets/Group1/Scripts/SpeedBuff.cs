using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuff : MonoBehaviour
{
    [SerializeField] private float _speedMultiplier;
    [SerializeField] private float _duration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.StartCoroutine(Apply(player));
            Destroy(gameObject);
        }
    }

    private IEnumerator Apply(Player player)
    {
        player.Speed *= _speedMultiplier;
        yield return new WaitForSeconds(_duration);
        player.Speed /= _speedMultiplier;
    }
}
