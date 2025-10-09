using UnityEngine;

public class SlowMotioneffect : MonoBehaviour
{
    public float slowMotionEffect = 0.02f;
    public float slowMotionTime = 3f;

    private void Update()
    {
        Time.timeScale += (1f/ slowMotionTime) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

    public void SlowMotion()
    {
        Time.timeScale = slowMotionEffect;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}