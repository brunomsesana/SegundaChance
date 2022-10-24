using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class CamSetter : MonoBehaviour
{
    PostProcessVolume v;
    Vignette vig;
    Grain gra;

    private void Awake()
    {
        v = GetComponent<PostProcessVolume>();
    }
    // Start is called before the first frame update
    void Start()
    {
        v.profile.TryGetSettings(out vig);
        v.profile.TryGetSettings(out gra);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.restarts <= 7)
        {
            vig.intensity.value = Player.restarts * 0.05f;
        } else
        {
            if (Player.restarts <= 20)
            {
                vig.intensity.value = 7 * 0.05f;
                gra.intensity.value = (Player.restarts - 7) * 0.5f;
            }
            else
            {
                vig.intensity.value = 7 * 0.05f;
                gra.intensity.value = 13 * 0.5f;
            }
        }
    }
}
